using System.Collections;

class Program{

    static IEnumerator Func(ArrayList myList){
        IEnumerator it = myList.GetEnumerator();
        while(it.MoveNext())
            if(it.Current is string)
                break;
        return it;
    }

    static void Main(){
        ArrayList myList = new ArrayList();

        int n, m; 
        int.TryParse(Console.ReadLine(), out n);
        int.TryParse(Console.ReadLine(), out m);

        for(int i = 0; i < n; i++){
            var x=0;
            int.TryParse(Console.ReadLine(), out x);
            myList.Add(x);
        }

        myList.Add("###");

        for(int i = 0; i < m; i++){
            myList.Add(Console.ReadLine());
        }

        IEnumerator it = Func(myList);
        while (it.MoveNext())
            Console.WriteLine(it.Current.ToString());        
    }
}


