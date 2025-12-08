using System;
using System.Threading;

public static class Zodiac
{
    // SLOW PRINT FUNCTION (3–5 sec)
    static void SlowPrint(string text, int delay = 180)
    {
        string[] lines = text.Split('\n');
        foreach (string line in lines)
        {
            Console.WriteLine(line);
            Thread.Sleep(delay);
        }
    }

    public static void Run()
    {
        Console.WriteLine("====== ZODIAC SIGN VIEWER ======\n");
        Console.Write("Enter your zodiac sign: ");
        string zodiac = (Console.ReadLine() ?? "").Trim().ToLower();

        Console.Clear();

        switch (zodiac)
        {
            case "aries":
                SlowPrint(@"
            ██████                          ██████            
          ███████████                    ████████████         
        ███        ███                  ███        ███        
       ███          ███                ███          ███       
       ██            ███              ███            ██       
       ██             ███            ███             ██       
       ███             ███          ███             ███       
        ████           ███          ███           ████        
          █████         ███        ███         █████          
                        ███        ███                        
                         ███      ███                         
                         ███      ███                         
                          ███    ███                          
                           ██    ██                           
                           ███  ███                           
                            ██  ██                            
                            ██████                            
                             ████                             
                              ██                              
                              ██ ");
                Console.WriteLine("\n===== ARIES =====");
                Console.WriteLine("Energetic, assertive, and bold. Aries are natural leaders — full of drive and courage.");
                break;

            case "taurus":
                SlowPrint(@"
        ██████                                  ██████        
        █████████                            █████████        
          █████████                        █████████          
               █████                      █████               
                █████                    █████                
                 █████                  █████                 
                  █████                █████                  
                  ██████              ██████                  
                   █████████      █████████                   
                     ████████████████████                     
                     █████████████████████                    
                  ████████          ████████                  
                 ██████                ██████                 
                █████                    █████                
               █████                      █████               
              █████                        █████              
             █████                          █████             
             █████                          █████             
              ████                          ████              
              █████                        █████              
               █████                      █████               
                ██████                  ██████                
                 ███████              ███████                 
                   ███████████  ███████████                   
                      ██████████████████                      
                         ████████████                         
                                                              ");
                Console.WriteLine("\n===== TAURUS =====");
                Console.WriteLine("Reliable, patient, and practical. Taurus values stability, loyalty, and the comforts of life.");
                break;

            case "gemini":
                SlowPrint(@"
       █                                                █     
       ███████                                     ██████     
         ███████████████                 ████████████████     
               █████████████████████████████████████          
                   █████████████████████████                  
                   █████               █████                  
                   █████               █████                  
                   █████               █████                  
                   █████               █████                  
                   █████               █████                  
                   █████               █████                  
                   █████               █████                  
                   █████               █████                  
                   █████               █████                  
                   █████               █████                  
                  ███████████████████████████                 
          █████████████████████████████████████████           
      ████████████                           ███████████      
      ████                                          ████");
                Console.WriteLine("\n===== GEMINI =====");
                Console.WriteLine("Versatile, communicative, and curious. Gemini loves variety, intellectual stimulation, and social connection.");
                break;

            case "cancer":
                SlowPrint(@"
                      ██████████████████                      
                   █████████████████████████                  
                 ██████                 ██████                
               █████████                   █████              
              ████████████                   █████            
             ████      ████                    ██             
            ████        ████             ████                 
            ███         ████          ██████████              
            ████        ████        █████    █████            
             █████    █████        ████        ████           
              ███████████          ████         ███           
                 ██████            ████        ████           
                                    ████      ████            
             █████                   █████████████            
              ██████                   █████████              
                ███████                  ██████               
                   ██████████     ██████████                  
                      ███████████████████                      ");
                Console.WriteLine("\n===== CANCER =====");
                Console.WriteLine("Emotional, nurturing, and protective. Cancer cares deeply about family, home, and close bonds.");
                break;

            case "leo":
                SlowPrint(@"
                           ███████████████                    
                        ██████        ███████                 
                       ████              █████                
                      ████                 ████               
                     ████                   ████              
                     ███                     ███              
                     ███                     ████             
                     ███                     ████             
                     ████                    ███              
                      ███                   ████              
                      ████                  ████              
                  ████ ████                ████               
              ██████████████              ████               
            ████        █████            ████                
           ███            ███           █████                
           ██              ███          ████                 
          ███              ███         ████                  
          ███              ███        ████                   
           ███             ███       ████                    
           ████           ███       ████                     
             ████      █████        ████                     
               ███████████         ████                      
                                   ████                      
                                   ████         ██           
                                    ██████   ██████          
                                     ████████████            ");
                Console.WriteLine("\n===== LEO =====");
                Console.WriteLine("Charismatic, confident, and natural-born leaders. Leo loves creativity, recognition and being in the spotlight.");
                break;

            case "virgo":
                SlowPrint(@"
                        ███   █████   █████                             
                         ███ ██  ██  ██  ██                             
                          ████    ████   ██                             
                          ███     ███    ██  ████                       
                          ██      ██     ██ █████                       
                          ██      ██     ████   ██                      
                          ██      ██     ███    ██                      
                          ██      ██     ███    ██                      
                          ██      ██     ██     ██                      
                          ██      ██     ██     ██                      
                          ██      ██     ██    ██                       
                          ██      ██     ██   ██                        
                          ██      ██     ██  ██                         
                          ██      ██     █████                          
                                         ███                            
                                     ███████                            
                                    ██    ███                           
                                           ██                            ");
                Console.WriteLine("\n===== VIRGO =====");
                Console.WriteLine("Detail-oriented, analytical, and practical. Virgo excels at organization, problem-solving and realism.");
                break;

            case "libra":
                SlowPrint(@"
                               ██████████                               
                             ███        ███                             
                            ███          ███                            
                            ██            ██                            
                            ███           ██                            
                             ██          ██                             
                       ██████████      ██████████                       
                       ██████████      ██████████                       
                                                   
                                                   
                       ██████████████████████████                       
                       ██████████████████████████");
                Console.WriteLine("\n===== LIBRA =====");
                Console.WriteLine("Diplomatic, fair-minded, and charming. Libra seeks balance, harmony and values relationships and beauty.");
                break;

            case "scorpio":
                SlowPrint(@"
                        ███   ████    ████                              
                         ██  ██  ██  █  ██                              
                          ████   ████   ██                              
                          ███    ███    ██                              
                          ██     ███    ██                              
                          ██     ██     ██                              
                          ██     ██     ██                              
                          ██     ██     ██                              
                          ██     ██     ██                              
                          ██     ██     ██                              
                          ██     ██     ██                              
                          ██     ██     ██                              
                          ██     ██     ██                              
                          ██     ██     ██                              
                          ██     ██      ██                             
                          ██     ██      ███   █                        
                                           ██████                       
                                               █    ");
                Console.WriteLine("\n===== SCORPIO =====");
                Console.WriteLine("Intense, passionate, and resourceful. Scorpio feels deeply — mysterious and powerful.");
                break;

            case "sagittarius":
                SlowPrint(@"
                                  ████████████████████                  
                                   ███████████████████                  
                                              ████████                  
                                            ██████████                  
                                          ███████ ████                  
                                         ██████   ████                  
                                       ██████     ████                  
                       ████          ██████       ████                  
                       █████       ███████        ████                  
                         █████   ███████          ████                  
                           ███████████                                  
                             ███████                                    
                            ████████                                    
                          ████████████                                  
                        ██████    █████                                 
                       █████        █████                                
                     █████            ███                                
                   █████                                                 
                 █████                                                   
                  ██                                                     ");
                Console.WriteLine("\n===== SAGITTARIUS =====");
                Console.WriteLine("Adventurous, optimistic, and freedom-loving. Sagittarius thrives on exploration and big ideas.");
                break;

            case "capricorn":
                SlowPrint(@"
                ████████           █████████                            
              ███████████         ████████████                          
             █████    ████       ████     █████                         
                       ████     ████       ████                         
                        ████   ████        ████                         
                        █████ ████         ████                         
                        ██████████         ████                         
                         ████████          ████                         
                         ████████          ████                         
                         ████████           ████                        
                         ████████           ████                        
                         ████████           ███████████████            
                          ██████            ███████      ███          
                          ██████              ████        ███         
                           ████               ████        ███         
                           ████               █████      ███          
                           ████              ██████████████           
                                          ████                
                                         ████                       
                                        ███                          
                                      ████                           
                                   █████
                               ███████      ");
                Console.WriteLine("\n===== CAPRICORN =====");
                Console.WriteLine("Disciplined, ambitious, and practical. Capricorn works steadily toward long-term success.");
                break;

            case "aquarius":
                SlowPrint(@"
                          ████         ███         ████                
                       ███████      ███████     ███████                
                     ██████████  ██████████  ███████████               
                  ███████  ██████████   █████████   ████              
                ██████     ███████      ██████       ███              
                ███         ███         ████         ███              
                                                                        
                           ███         ███         ████               
                        ██████      ███████      ██████               
                     ██████████   █████████   ██████████              
                  ███████  ██████████  ██████████   ████              
                ██████     ███████      ███████      ███              
                ███         ████        ████         ███ ");
                Console.WriteLine("\n===== AQUARIUS =====");
                Console.WriteLine("Innovative, humanitarian, and independent. Aquarius thinks outside the box and values originality.");
                break;

            case "pisces":
                SlowPrint(@"
                    █████                      █████                    
                     █████                    █████                     
                      █████                  █████                      
                       █████                ████                        
                         ████              ████                         
                          ████            ████                          
                          █████          █████                          
                           ████          ████                           
                           ████          ████                           
                            ████        ████                            
                     ██████████████████████████████                     
                    ████████████████████████████████                    
                           ██████████████████                           
                            ████        ████                            
                           ████          ████                           
                           ████          ████                           
                          ████            ████                          
                          ████            ████                          
                         ████              ████                         
                         ███                ███                         
                        ███                  ███  ");
                Console.WriteLine("\n===== PISCES =====");
                Console.WriteLine("Compassionate, intuitive, and dreamy. Pisces connects deeply with emotion and imagination.");
                break;

            default:
                Console.WriteLine("Unknown zodiac sign. Try again (e.g. Aries, Taurus, Gemini...).");
                break;
        }

        Console.WriteLine("\n\nPress any key to exit...");
        Console.ReadKey();
    }
}
