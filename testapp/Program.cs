using System.Threading;
using testlib;

namespace testapp {
    class Program {
        public static void Main(string[] args) {
            Thread t = new Thread(() => {
                System.Console.WriteLine("Hello, World!"); 
                LibClass.WriteOutput();
            });
            
            t.Start();
            t.Join();
        }
    }
}
