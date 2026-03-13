using System;
using System.Collections.Generic;
using System.Text;

namespace modul4_103082400005
{
    internal class PosisiKarakterGame
    {

        private enum MyPosition {Berdiri, Jongkok, Terbang, Tengkurap};
        private readonly String[] description = ["posisi standby", "posisi istirahat"];
        
        private MyPosition myCurrentPosition = MyPosition.Berdiri;

        public PosisiKarakterGame()
        {
            ChangePosition();
        }

        private void ChangePosition()
        {

            String input = "Start Game Loop";

            while (!String.IsNullOrEmpty(input))
            {
                Console.Clear();
                WriteInfo(myCurrentPosition);
                input = ReadPlayerInput();


                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("\nGame Over.");
                    break;
                }


                switch (myCurrentPosition)
                {
                    case MyPosition.Berdiri:
                        if (input == "TombolW")
                        {
                            Console.WriteLine("posisi take off");
                            myCurrentPosition = MyPosition.Terbang;
                        }
                        else if (input == "TombolS")
                        {
                            myCurrentPosition = MyPosition.Jongkok;
                        }
                        else if (input == "TombolX")
                        {
                            WriteNothingHappend();
                        }
                        break;

                    case MyPosition.Jongkok:
                        if (input == "TombolW")
                        {
                            myCurrentPosition = MyPosition.Berdiri;

                        }
                        else if (input == "TombolS")
                        {
                            myCurrentPosition = MyPosition.Tengkurap;

                        }
                        else if (input == "TombolX")
                        {
                            WriteNothingHappend();
                        }
                        break;

                    case MyPosition.Terbang:
                        if (input == "TombolW")
                        {
                            WriteNothingHappend();
                        }
                        else if (input == "TombolS")
                        {
                            myCurrentPosition = MyPosition.Berdiri;
                        }
                        else if (input == "TombolX")
                        {
                            Console.WriteLine("posisi landing");
                            myCurrentPosition = MyPosition.Jongkok;
                        }
                        break;

                    case MyPosition.Tengkurap:
                        if (input == "TombolW")
                        {
                            myCurrentPosition = MyPosition.Jongkok;
                        }
                        else if (input == "TombolS")
                        {
                            WriteNothingHappend();
                        }
                        else if (input == "TombolX")
                        {
                            WriteNothingHappend();
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
                    Console.WriteLine("\nTekan Enter untuk melanjutkan...");
                    Console.ReadLine();
            }  
        }

        private static String ReadPlayerInput()
        {
            Console.WriteLine("\n\nPlease Submit Command" +
                "\n(Jokes)Keep It Blank To End Your Live >:}"+
                "\n\nAvailable Input: (TombolW), (TombolS), (TombolX)"
                );


            Console.Write("Masukan Aksi: ");
            String input = Console.ReadLine();

            if (input.Equals("TombolW")) Console.WriteLine("tombol arah atas ditekan...");
            else if (input.Equals("TombolS")) Console.WriteLine("tombol arah bawah ditekan...");

            return input;
        }

        private static void WriteNothingHappend()
        {
            Console.WriteLine("Nothing Happend...");
        }

        private void WriteInfo(MyPosition myCurrentPosition)
        {
            Console.WriteLine("\nLiterally Posisi Gua Sekarang: " + myCurrentPosition);
            if ((int)myCurrentPosition < 2) Console.WriteLine(description[(int)myCurrentPosition]);
        }
    }
}

