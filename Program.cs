class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Plesae Input Number Of Stall");
        int Num_Stall = int.Parse(Console.ReadLine());
        char [] Stall = new char [Num_Stall];
        int Stop = 0;
        for (int i = 0;i<Num_Stall;i++)
        {
            Stall[i] = '_';
        }
        while(Stop<Num_Stall-1)
        {
            Console.WriteLine("Plesae Input Location Of Stall");
            int Location_A = int.Parse(Console.ReadLine());
            int Location_B = int.Parse(Console.ReadLine());
            if ((Location_A<1)&&(Location_B<1))
            {
                Stop=Num_Stall;
            }

            else
            {
                if (Stop<Num_Stall)
                {
                    if (Location_A==Location_B)
                    {
                        Stall[Location_A-1] = 'X';
                        Stop++;
                    }
                    else
                    {
                      if ((Location_A>0)&&(Location_B>0))
                      {
                        if (Stop+2>=Num_Stall)
                        {
                            Console.WriteLine("The entrance can't be reserved.");
                        }
                        else if ((Stall[Location_A-1]=='X')||(Stall[Location_B-1]=='X'))
                        {
                            Console.WriteLine("The stall is reserved.");
                        }
                        else
                        {
                            Stall[Location_A-1] = 'X';
                            Stall[Location_B-1] = 'X';
                            Stop = Stop+2;
                        }
                        
                      }
                      else
                      {
                        if (Location_A>0)
                        {
                            if (Stall[Location_A-1]=='_')
                            {
                                Stall[Location_A-1] = 'X';
                                Stop++;
                            }
                            else
                            {
                                Console.WriteLine("The stall is reserved.");
                            }
                        }
                        if (Location_B>0)
                        {
                            if (Stall[Location_B-1]=='_')
                            {
                                Stall[Location_B-1] = 'X';
                                Stop++;
                            }
                            else
                            {
                                Console.WriteLine("The stall is reserved.");
                            }
                        }
                      }

                    }
                }
                else
                {
                    Console.WriteLine("All stall are reserved.");
                }
            }
            Console.WriteLine(Stall);
            
        }
        
    }
}
