/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            bool correct = false;
              

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {
                while (!correct)
                    try
                    {
                        // affiche le menu et saisi le choix
                        Console.WriteLine("Addition ....................... 1");
                        Console.WriteLine("Multiplication ................. 2");
                        Console.WriteLine("Quitter ........................ 0");
                        Console.Write("Choix :                          ");
                        choix = int.Parse(Console.ReadLine());

                        // traitement des choix
                        switch (choix)

                        {
                            case 1:
                                while (!correct)

                                    try
                                    {

                                        

                                        // choix de l'addition
                                        val1 = rand.Next(1, 10);
                                        val2 = rand.Next(1, 10);
                                        
                                            
                                        
                                           
                                        
                                        // saisie de la -réponse                                                                            
                                    Console.Write(val1 + " + " + val2 + " = ");

                                        reponse = int.Parse(Console.ReadLine());

                                        // comparaison avec la bonne réponse
                                        solution = val1 + val2;
                                        if (reponse == solution)
                                                    
                                                {
                                                    Console.WriteLine("Bravo !");
                                            break;
                                                }

                                        else
                                                {
                                                    Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                                                   
                                        }
                                        
                                                
                                                

                                           

                                        


                                    }
                                    catch
                                    {
                                                                             
                                        Console.WriteLine("Erreur de saisie : saisissez un nombre entier ");
                                        
                                                                            


                                    }


                                
                                break;




                            case 2:
                                while (!correct)
                                    try
                                    {

                                        // choix de la multiplication
                                        val1 = rand.Next(1, 10);
                                        val2 = rand.Next(1, 10);
                                        // saisie de la réponse
                                        Console.Write(val1 + " x " + val2 + " = ");
                                        reponse = int.Parse(Console.ReadLine());
                                        // comparaison avec la bonne réponse
                                        solution = val1 * val2;
                                        if (reponse == solution)
                                        {
                                            Console.WriteLine("Bravo !");
                                        }
                                        else
                                        {
                                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                                        }
                                        break;



                                    }
                                    catch
                                    {
                                        Console.WriteLine("Erreur de saisie : saisissez un nombre entier");
                                    }
                                break;
                            default:
                                Console.WriteLine("Choisissez seulement un des choix proposés");
                                break;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Erreur de saisie");
                    }

                }
            }

        }
    }

