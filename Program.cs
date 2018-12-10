using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace tellocore
{
    class Program
    {
        static void Main(string[] args)
        {

           using(TelloAction telloAction = new TelloAction())
           {
               telloAction.Connect(8889);
               telloAction.Command("command");
               telloAction.Command("streamon");

            bool cmd = true;


            while(cmd)
            {
                Console.Clear();
                Console.WriteLine("1.take off");
                Console.WriteLine("2.land");
                Console.WriteLine("3.left 20cm");
                Console.WriteLine("4.right 20cm");
                Console.WriteLine("5.foward 20cm");
                Console.WriteLine("6.back 20cm");
                Console.WriteLine("7.up 20cm");
                Console.WriteLine("8.down 20cm");
                Console.WriteLine("9.turn 20 degree");
                Console.WriteLine("10.foturn 20 degree");
                Console.WriteLine("11.exit");
                var choice = Console.ReadLine();
                try
                {
                    switch (choice)
                    {
                        case "1":
                            {
                                Console.WriteLine("takeoff");
                                telloAction.Command("takeoff");
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("land");
                                telloAction.Command("land");
                                break;
                            }
                        case "3":
                            {
                                Console.WriteLine("left 20");
                                telloAction.Command("left 20");
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("right 20");
                                telloAction.Command("right 20");
                                break;
                            }
                        case "5":
                            {
                                Console.WriteLine("forward 20");
                                telloAction.Command("forward 20");
                                break;
                            }
                        case "6":
                            {
                                Console.WriteLine("back 20");
                                telloAction.Command("back 20");
                                break;
                            }
                        case "7":
                            {
                                Console.WriteLine("up 20");
                                telloAction.Command("up 20");
                                break;
                            }
                        case "8":
                            {
                                Console.WriteLine("down 20");
                                telloAction.Command("down 20");
                                break;
                            }
                        case "9":
                            {
                                Console.WriteLine("turn 20");
                                telloAction.Command("cw 20");
                                break;
                            }
                        case "10":
                            {
                                Console.WriteLine("foturn 20");
                                telloAction.Command("ccw 20");
                                break;
                            }
                        case "11":
                            {
                                cmd = false;
                                
                                telloAction.Command("land");
                                
                                telloAction.Close();
                                break;
                            }
                    }

                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    Console.ReadLine();
                }

            }

           }
        }



    }
}
