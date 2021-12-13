using System;

namespace pimrada
{
    class Node{
        public int Distance;
        public string Name;
        public static Node Last;
        public Node Left;
        public Node Right;
        public static Node[] land = new Node[99];
        public Node (string Name){
            this.Name = Name;
            Distance = 0;
            Left = null;
            Right = null;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name= "";
            int amount = int.Parse(Console.ReadLine());
            for(int i=0; i<amount; i++){
                name = Console.ReadLine();
                Node.land[i] = new Node(name);
            }
            MethodLoop(amount);
            FindLast(amount);
            Result(amount);
        }

        static void MethodLoop(int valueAmount){
            for(int i=1;i<valueAmount;i++){
                for(int j=0;j<i;j++){
                    int Distance = int.Parse(Console.ReadLine());
                    if(Distance != -1){
                        if(Node.land[i].Left == null){
                            Node.land[i].Left = Node.land[j];
                            Node.land[i].Left.Distance = Distance;
                        }
                        else if(Node.land[i].Right == null){
                            Node.land[i].Right = Node.land[j];
                            Node.land[i].Right.Distance = Distance;
                        }
                    }
                }
                Console.WriteLine();
            }
        }
        static void FindLast(int valueAmount){
            string lastLand = Console.ReadLine();
            for(int i=0;i<valueAmount;i++){
                if(lastLand == Node.land[i].Name){
                    Node.Last = Node.land[i];
                }
            }
        }
        static void Result(int valueAmount){
            int result = 0;
            int temp = 0;
            if(Node.Last.Left != Node.land[0] && Node.Last.Left != null){
                temp = temp+Node.Last.Left.Distance;
                if(Node.Last.Left.Left != Node.land[0] && Node.Last.Left.Left != null){
                    temp = temp+Node.Last.Left.Left.Distance;
                    if(Node.Last.Left.Left.Left != Node.land[0] && Node.Last.Left.Left.Left != null){
                        temp = temp+Node.Last.Left.Left.Left.Distance;
                    }
                }
                
            }
            if(result == 0 || temp < result){
                result = temp;
                temp = 0;
            }
            if(Node.Last.Left != Node.land[0] && Node.Last.Left != null){
                temp = temp+Node.Last.Left.Distance;
                if(Node.Last.Left.Left != Node.land[0] && Node.Last.Left.Left != null){
                    temp = temp+Node.Last.Left.Left.Distance;
                    if(Node.Last.Left.Left.Right != Node.land[0]&& Node.Last.Left.Left.Right != null){
                        temp = temp+Node.Last.Left.Left.Right.Distance;
                    }
                }
            }
            if(result == 0 || temp < result){
                result = temp;
                temp = 0;
            }
            if(Node.Last.Left != Node.land[0] && Node.Last.Left != null){
                temp = temp+Node.Last.Left.Distance;
                if(Node.Last.Left.Right != Node.land[0] && Node.Last.Left.Right != null){
                    temp = temp+Node.Last.Left.Right.Distance;
                    if(Node.Last.Left.Right.Left != Node.land[0]&& Node.Last.Left.Right.Left != null){
                        temp = temp+Node.Last.Left.Right.Left.Distance;
                    }
                }
            }
            if(result == 0 || temp < result){
                result = temp;
                temp = 0;
            }
            if(Node.Last.Left != Node.land[0] && Node.Last.Left != null){
                temp = temp+Node.Last.Left.Distance;
                if(Node.Last.Left.Right != Node.land[0] && Node.Last.Left.Right != null){
                    temp = temp+Node.Last.Left.Right.Distance;
                    if(Node.Last.Left.Right.Right != Node.land[0]&& Node.Last.Left.Right.Right != null){
                        temp = temp+Node.Last.Left.Right.Right.Distance;
                    }
                }
            }
            if(result == 0 || temp < result){
                result = temp;
                temp = 0;
            }
            if(Node.Last.Right != Node.land[0] && Node.Last.Right != null){
                temp = temp+Node.Last.Right.Distance;
                if(Node.Last.Left.Left != Node.land[0] && Node.Last.Left.Left != null){
                    temp = temp+Node.Last.Right.Left.Distance;
                    if(Node.Last.Right.Left.Left != Node.land[0] && Node.Last.Right.Left.Left != null){
                        temp = temp+Node.Last.Right.Left.Left.Distance;
                    }
                }
            }
            if(result == 0 || temp < result){
                result = temp;
                temp = 0;
            }
            if(Node.Last.Right != Node.land[0] && Node.Last.Right != null){
                temp = temp+Node.Last.Right.Distance;
                if(Node.Last.Right.Left != Node.land[0] && Node.Last.Right.Left != null){
                    temp = temp+Node.Last.Right.Left.Distance;
                    if(Node.Last.Right.Left.Right != Node.land[0]&& Node.Last.Right.Left.Right != null){
                        temp = temp+Node.Last.Right.Left.Right.Distance;
                    }
                }
            }
            if(result == 0 || temp < result){
                result = temp;
                temp = 0;
            }
            if(Node.Last.Right != Node.land[0] && Node.Last.Right != null){
                temp = temp+Node.Last.Right.Distance;
                if(Node.Last.Right.Right != Node.land[0] && Node.Last.Right.Right != null){
                    temp = temp+Node.Last.Right.Right.Distance;
                    if(Node.Last.Right.Right.Left != Node.land[0]&& Node.Last.Right.Right.Left != null){
                        temp = temp+Node.Last.Right.Right.Left.Distance;
                    }
                }
            }
            if(result == 0 || temp < result){
                result = temp;
                temp = 0;
            }
            if(Node.Last.Right != Node.land[0] && Node.Last.Right != null){
                temp = temp+Node.Last.Right.Distance;
                if(Node.Last.Right.Right != Node.land[0] && Node.Last.Right.Right != null){
                    temp = temp+Node.Last.Right.Right.Distance;
                    if(Node.Last.Right.Right.Right != Node.land[0]&& Node.Last.Right.Right.Right != null){
                        temp = temp+Node.Last.Right.Right.Right.Distance;
                    }
                }
            }
            if(result == 0 || temp < result){
                result = temp;
                temp = 0;
            }
            Console.WriteLine(result);
        }
    }
}
