using System;
using System.Collections.Generic;
using System.Linq;

namespace amazonChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new List<String>(){"3 2 50", "3 2 70", "1 3 20", "1 2 17"};
            //ProcessLogs(list, 2).ForEach(l => Console.WriteLine(l));
            //var startIndices = new List<int>(){1,1};
            //var endIndices = new List<int>(){5,6};
            //numberOfItems("|***|*", startIndices, endIndices).ForEach(l => Console.WriteLine(l));

            var list = new List<int>(){2, 2, 1, 5, 3};
            Console.WriteLine(maximumQuality(list, 2));            
        }

    public static long maximumQuality(List<int> packets, int channels)
    {
        List<List<int>> channelsList = new List<List<int>>();
        packets = packets.OrderBy(m => m).ToList(); //ordeno por ordem crescente      
        long sum = 0;
       
        if(channels == packets.Count){
            for(int i=0; i < channels; i++){
                channelsList.Add(new List<int>{ packets[i] });   
            }
        }            
        else{ //channels sempre menor que ou igual. 
            //PEGAR MAIOR PACOTE E COLOCAR NO PRÓXIMO CANAL.
            for(int i = 0; i < channels -1; i++){
                
                channelsList.Add(new List<int>{ packets[(packets.Count - i) - 1] });
            }
            for(int i = 0; i <= packets.Count - channelsList.Count; i++){
                if(i == 0){
                    channelsList.Add(new List<int>{ packets[i] } ); //crio o canal acumulador
                }
                else channelsList[channels -1].Add( packets[i]); //adiciono no canal acumulador
            }
        }
        int canal = 0;
        channelsList.ForEach(
            l => {
                canal +=1;
                Console.WriteLine($"Canal: {canal}");
                if(l.Count % 2 == 0){//par
                    //média dos 2 elementos do meio
                    sum = sum + (l[(l.Count / 2) -1] + l[(l.Count / 2)]) / 2;
                }
                else{
                    //int middle = Math.Ceiling(l.Count) / 2.0) + 1;
                    sum = sum + l[l.Count / 2];  //elemento do meio
                }

                l.ForEach(i => Console.WriteLine(i));
            }
        );
        return sum;
    }



        public static List<int> numberOfItems(string s, List<int> startIndices, List<int> endIndices)
        {
            int end=0;
            int sum=0, countTotal=0, separator=0;
            List<int> values = new List<int>();
            foreach(int item in startIndices){
                end = endIndices[item];                
                
                foreach(char character in s){
                    if(character == Convert.ToChar("|")){
                        separator += 1;
                    }
                    else{
                        if(separator == 1){
                            sum += 1;
                        }
                        else if(separator == 2){
                            countTotal = sum;
                            separator = 1;
                        }
                    }               
                }
                values.Add(countTotal);
            }
            return values;
        }

        public static List<string> ProcessLogs(List<string> logs, int threshold)
        {
            Dictionary<string, int> values = new Dictionary<string, int>(); 
            List<string> ids = new List<string>();           
        
            foreach(string log in logs){
                string[] transaction = log.Split(" ");
                for(int i=0; i < 2; i++){
                    if(transaction[0] == transaction[1] && i == 1)
                        continue;

                    if(values.ContainsKey(transaction[i]))
                        values[transaction[i]] += 1;
                    else
                        values.Add(transaction[i], 1);                                  
                }
            }
            foreach(var item in values){
                if(item.Value >= threshold) ids.Add(item.Key);
            }
            return ids.OrderBy(l => Convert.ToInt64(l)).ToList();
        }
    }
}
