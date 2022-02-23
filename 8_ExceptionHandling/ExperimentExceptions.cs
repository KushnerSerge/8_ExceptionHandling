using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ExceptionHandling
{
    public class ExperimentExceptions
    {


        public static void readAndwriteFromFile()
        {

            try
            {
                StreamReader streamReader = new StreamReader("C:\\SampleFiles\\Data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
            }
            catch(DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.GetType().Name);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
             //   Console.WriteLine(ex.ToString());
             //   Console.WriteLine(ex.StackTrace);
               Console.WriteLine(ex.Message);
               

            }
            finally
            {
                Console.WriteLine("Finaly block executed");
            }
        }

        public void arrayOperations(int[] arrayObj, int value)
        {
            var result = 0;
            try
            {
                foreach (var item in arrayObj)
                {
                    result = item / value;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Block executed");
            }
            return;
        }
    }
}
