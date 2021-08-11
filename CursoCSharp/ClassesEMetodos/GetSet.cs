using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos
{
    public class Moto
    {
        private string Marca;
        private string Modelo;
        private uint Cilindrada; //uint não vai permitir que voce coloque um numero negativo.

        public Moto(string marca, string modelo, uint cilindrada){
            //Marca = marca;
            //Modelo = modelo;
            //Cilindrada = cilindrada;
            setMarca(marca);
            setModelo(modelo);
            setCilindrada(cilindrada);
        }

        public Moto() {

        }

        public string getMarca(){
            return Marca;
        }

        public void setMarca(string marca) {
            Marca = marca;
        }

        public string getModelo() {
            return Modelo;
        }

        public void setModelo(string modelo) {
            Modelo = modelo;
        }

        public uint getCilindrada() {
            return Cilindrada;
        }

        public void setCilindrada(uint cilindrada){
            //1°Opção:
            // Cilindrada = Math.Abs(cilindrada); //Para garantir de não setar um valor negativo. ele trasnforma para positivo
            //2°Opção: mudar o tipo da variavel Cilindrada para uint
            Cilindrada = cilindrada;
        }
    }
    class GetSet
    {
        public static void Executar(){
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);

            Console.WriteLine(moto1.getMarca());
            Console.WriteLine(moto1.getModelo());
            Console.WriteLine(moto1.getCilindrada());

            var moto2 = new Moto();
            moto2.setMarca("Honda");
            moto2.setModelo("CG Tinta");
            moto2.setCilindrada(150);
            Console.WriteLine(moto2.getMarca() + " " + moto2.getModelo() + " " + moto2.getCilindrada());
        }
    }
}
