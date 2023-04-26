class Program
{
    static void Stall_Reseved(bool x)
    {
        if (x==true)
        {
            Console.WriteLine("The stall is reserved.");
        }
    }
     static void Stall_All(bool x)
    {
        if (x==true)
        {
            Console.WriteLine("All stall are reserved.");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Plesae Input Number Of Stall");
        int Num_Stall = int.Parse(Console.ReadLine());
        char [] Stall = new char [Num_Stall];
        int [] Input_Num = new int [2];
        bool StallIsReseved = false;
        bool StallIsAll = false;
        for (int i = 0;i<Num_Stall;i++)
        {
            Stall[i] = '_';
        }
        Console.WriteLine(Stall);
        int Stall_Break = 0;
        
        while (true)
        {
            for (int i = 0;i<2;i++)
            {
                Console.WriteLine("Plesae Input Location Of Stall");
                int Stall_Position = int.Parse(Console.ReadLine());
                if (Stall_Position<=Num_Stall)
                {
                    Input_Num[i] = Stall_Position;
                }
                
            }

            Console.WriteLine(Input_Num);
            
            for (int i = 0;i<Num_Stall;i++)
                    {
                        if (Stall[i]=='X')
                        {
                            Stall_Break++;
                        }

                        if (Stall_Break>=Num_Stall)
                        {
                            Stall_All(true);
                            StallIsAll = true;
                            break;
                        }
                    }
            
            for (int i = 0;i<2;i++)
            {
                if (Stall[Input_Num[i]]=='X')
                {
                    Stall_Reseved(true);
                    StallIsReseved = true;
                    break;
                }
            }

            if ((StallIsAll==false)&&(StallIsReseved==false))
            {
                for (int i = 0;i<2;i++)
                {
                   if (Input_Num[i]>0)
                   {
                    Stall[Input_Num[i]-1] = 'X';
                   }
                }
            }





            
            Console.WriteLine(Stall);
        }
    }
}
