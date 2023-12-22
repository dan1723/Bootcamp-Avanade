using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo2.Models
{
    public class Exececao
    {
        public void mt1(){
           try{
                mt2();
            }catch(Exception ex){
                Console.WriteLine("Exceção tratada. " + ex.Message);
            }
            
        }

        public void mt2(){
            mt3();
        }

        public void mt3(){
            mt4();
        }

        public void mt4(){
            throw new Exception("Ocorreu uma exceção");
        }
    }
}