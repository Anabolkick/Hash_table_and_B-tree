using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2_2
{
    public class B_tree
    {
        private int M; //порядок
        public B_node Root_node;

        public B_tree(int m)
        {
            M = m;
            B_node root_node = new B_node(M) { isLeaf = true };
            Root_node = root_node;
        }

        public void Add(int value)
        {

            if (Root_node.Children_nodes.Count == 0 && Root_node.KeysUsed == 0) //если есть только корень
            {
                Root_node.Keys[0] = value;
                Root_node.KeysUsed++;
            }
            else
            {
                var curr_node = Root_node;

                check_keys: //сравнение ключей с добавляемым значением

                B_node node = null;
                for (int i = 0; i < curr_node.MaxKeysCount; i++)
                {
                    if (curr_node.Keys[i] == null)      //ключа нет
                    {
                        if (curr_node.Children_nodes.Count >= i + 1)   
                        {
                            node = curr_node.Children_nodes[i];
                            break;
                        }
                        else
                        {
                            node = curr_node;
                            break;
                        }
                    }
                    if (value <= curr_node.Keys[i]) //значние меньше\равно ключа
                    {
                        if (curr_node.Children_nodes.Count >= i + 1)   // Если есть ребенок слева оt ключа
                        {
                            node = curr_node.Children_nodes[i];
                            break;
                        }
                        else
                        {
                            node = curr_node;
                            break;
                        }
                    }
                    else if (curr_node.Children_nodes.Count >= i + 1 && i == curr_node.MaxKeysCount - 1 &&    //Есть ребенок справа и это последний ключ и все заполненно
                             curr_node.KeysUsed == curr_node.MaxKeysCount && value >= curr_node.Keys[curr_node.MaxKeysCount - 1]) //все заполненно и значение больше ключа
                    {
                        node = curr_node.Children_nodes[curr_node.Children_nodes.Count - 1]; //последний нод среди детей
                        break;
                    }
                    else if(i == curr_node.MaxKeysCount - 1 && curr_node.KeysUsed == curr_node.MaxKeysCount) //проверяем последний ключ и нод заполнен и нет детей
                    {
                        node = curr_node;
                        break;
                    }
                }

                if (node.isLeaf)
                {
                    if (Add_element(ref node))
                    {
                        return;
                    }
                }
                else
                {
                    //useless code???
                    //  curr_node = node.Children_nodes[0];
                    curr_node = node;
                    goto check_keys;
                }
            }



            bool Add_element(ref B_node node)
            {
                for (int i = 0; i < node.MaxKeysCount; i++) //после которого ключа вставлять
                {
                    var key = node.Keys[i];

                    if (value <= key || key == null || node.KeysUsed == node.MaxKeysCount) //ключ больше значения или ключа нет или все ключи заняты
                    {
                        new_parent:

                        if (node.KeysUsed != node.MaxKeysCount) //если в ноде есть места
                        {
                            for (var j = i; j < node.KeysUsed; j++) //смещение вправо
                            {
                                node.Keys[j + 1] = node.Keys[j];
                                node.Keys[j] = null; //???????????????????????
                            }

                            node.Keys[i] = value;
                            node.KeysUsed++;
                            return true;
                        }
                        else if (node.KeysUsed == node.MaxKeysCount) //если в ноде нет места
                        {
                            bool done = false;
                            while (!done)
                            {
                                var parent_node = node.Parent_node;
                                B_node newNode = new B_node(M) { Parent_node = parent_node };

                                if (node.isLeaf)
                                {
                                    newNode.isLeaf = true;
                                }

                                if (node == Root_node) //новый корень
                                {
                                    parent_node = new B_node(M);
                                    node.Parent_node = parent_node;
                                    parent_node.Children_nodes.Add(node);
                                    Root_node = parent_node;
                                }

                                int mid_index = 0;

                                for (int j = 0; j < node.KeysUsed; j++)
                                {
                                    if (node.Keys[j] >= value)  // если ключ больше\равно значения 
                                    {
                                        for (int g = 0; g < node.KeysUsed - j; g++) //смещение вправо
                                        {
                                            node.Keys[node.MaxKeysCount - g] = node.Keys[node.MaxKeysCount - 1 - g]; //с конце перемещаем 
                                        }
                                        node.Keys[j] = value;
                                        break;
                                    }
                                    else if (j == node.KeysUsed - 1)     // если значение больше всех ключей 
                                    {
                                        node.Keys[j + 1] = value;
                                        break;
                                    }
                                }

                                mid_index = (int)Math.Ceiling((decimal)node.Keys.Length / 2) - 1;
                                int mid_value = (int)node.Keys[mid_index];
                                node.Keys[mid_index] = null;
                               // node.KeysUsed--;
                                //те что слева оставляем, те что справа - в новый нод
                                var right_count = node.Keys.Length - mid_index - 1; //количество индексов справа от среднего
                       
                                for (int j = 0; j < right_count; j++) //перенос значений справа в новый нод
                                {
                                    newNode.Keys[j] = node.Keys[node.Keys.Length - right_count + j];
                                    node.Keys[node.Keys.Length - right_count + j] = null;
                                    newNode.KeysUsed++;
                                    node.KeysUsed--;     //For 4?????????????????????????
                                }

                                //перераспределение родителей
                                int count = node.Children_nodes.Count;
                                if (count > M)
                                {
                                    int node_child_count = count / 2;
                                    int new_node_child_count = count - node_child_count;
                                    for (int k = 0; k < new_node_child_count; k++)
                                    {
                                        newNode.Children_nodes.Add(node.Children_nodes[new_node_child_count-1]);
                                        node.Children_nodes[new_node_child_count-1].Parent_node = newNode;

                                        node.Children_nodes.Remove(node.Children_nodes[new_node_child_count-1]);
                                    }

                                }

                                //перенос значения в высший
                                if (parent_node.KeysUsed != parent_node.MaxKeysCount) //если в родителе есть место
                                {
                                    for (int j = 0; j < parent_node.MaxKeysCount; j++)
                                    {
                                        if (parent_node.Keys[j] >= mid_value)
                                        {
                                            for (int g = 0; g < parent_node.MaxKeysCount-j; g++) //смещение вправо
                                            {
                                                parent_node.Keys[parent_node.MaxKeysCount - g] = parent_node.Keys[parent_node.MaxKeysCount - 1 - g]; //с конце перемещаем 
                                            }                                                           

                                            parent_node.Keys[j] = mid_value;
                                            parent_node.KeysUsed++;
                                            done = true;
                                            break;
                                        }
                                        else if (parent_node.Keys[j] == null)
                                        {
                                            parent_node.Keys[j] = mid_value;
                                            parent_node.KeysUsed++;
                                            done = true;
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    // если в родителе тоже нет места
                                    B_node find_node_1 = node;
                                    var index_1 = parent_node.Children_nodes.FindIndex(x => x == find_node_1);
                                    parent_node.Children_nodes.Insert(index_1 + 1, newNode);
                                    newNode.Parent_node = parent_node;

                                    node = new B_node(M);        // что б указывал на новый объект
                                    node = parent_node;
                                    value = mid_value;
                                    goto new_parent;   //повторяем по отношению к родителю
                                }

                                // добавляем новый нод
                                B_node find_node = node;
                                var index = parent_node.Children_nodes.FindIndex(x => x == find_node);
                                parent_node.Children_nodes.Insert(index + 1, newNode);
                                newNode.Parent_node = parent_node;
                                return true;
                            }
                             
                        }
                        else
                        {
                            throw new Exception("ERRROE");
                        }
                    }
                }

                return false;
            }
        }
    }
}


