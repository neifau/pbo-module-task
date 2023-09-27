using System;

namespace tugas
{ 
class Processor
{
    public string merk, tipe; 
    //public, dapat diakses siapa saja
    //class processor memiliki properti string (merk dan tipe) 
     public Processor(string merk_, string tipe_)
        {
         this.merk = merk_;
         this.tipe = tipe_;
        }
    }
class Intel : Processor
//Intel merupakan subclass dari Processor
    {
     public Intel(string tipe_, string merk_ = "Intel") : base(merk_, tipe_)
        {
         
        }
}
class Corei3 : Intel
//Corei3 merupakan subclass dari Intel
    {
    public Corei3(string tipe_ = "Core i3") : base( tipe_)
        {

        }
    }
class Corei5 : Intel
//Corei5 merupakan subclass dari Intel
    {
    public Corei5(string tipe_ = "Core i5") : base( tipe_)
        {
   
        }
    }
class Corei7 : Intel
//Corei7 merupakan subclass dari Intel
    {
    public Corei7(string tipe_ = "Core i7") : base( tipe_)
        {

        }
    }

class AMD : Processor
//AMD merupakan sublass dari Processor
    {
    public AMD(string tipe_, string merk_ = "AMD") : base(merk_, tipe_)
        {

        }
    }
class Ryzen : AMD
//Ryzen merupakan sublass dari AMD
    {
    public Ryzen(string tipe_ = "RAYZEN") : base(tipe_)
        {

        }
    }
class Athlon : AMD
//Athlon merupakan sublass dari AMD
    {
        public Athlon(string tipe_ = "ALTHON") : base(tipe_)
        {

        }
    }


class Vga
    {
    public string merk;
        public Vga (string merk_)
        {
        this.merk = merk_;
        }
    }
class Nvidia : Vga
//Nvidia merupakan sublass dari Vga
    {
    public Nvidia(string merk_ = "Nvidia") : base(merk_)
        {

        }
    }
class amd : Vga
//amd merupakan subclass dari Vga
    {
    public amd(string merk_ = "AMD") : base(merk_)
        {

        }
    }


class Laptop
{
    public string merk, tipe; 
    //mendifinisikan properti merk, tipe, bertipe data string, dan dapat diakses siapa saja
    public Vga vga;
    //mendefinisikan properti vga, bertipe data Vga, dan dapat diakses siapa saja
    public Processor processor;
    //mendefinisikan properti processor, bertipe data Processor, dan dapat diakses siapa saja
    public Laptop (string merk_, string tipe_, Vga vga_, Processor processor_)
    {
        this.merk = merk_;
        this.tipe = tipe_;
        this.vga = vga_;
        this.processor = processor_;
    }
    public void LaptopDinyalakan()
        //membuat method LaptopDinyalakan
    { 
        Console.WriteLine($"Laptop {merk} {tipe} menyala");
    }
    public void LaptopDimatikan()
    //membuat method LaptopDimatikan
    {
        Console.WriteLine($"Laptop {merk} {tipe} mati");
    }
}

class ASUS : Laptop
//ASUS merupakan subclass dari Laptop
    {
    public ASUS(string tipe_, Vga vga_, Processor processor_, string merk_ = "ASUS") : base( merk_,tipe_, vga_, processor_)
        {

        }
    }
class ROG : ASUS
//ROG merupakan subclass dari ASUS
    {
    public ROG(Vga vga_, Processor processor_, string tipe_ = "ROG") : base(tipe_, vga_, processor_)
        {

        }
    }
class Vivobook : ASUS
//Vivobook merupakan subclass dari ASUS
    {
        public Vivobook(Vga vga_, Processor processor_, string tipe_ = "Vivobook") : base(tipe_, vga_, processor_)
        {

        }
    public void Ngoding()
    //membuat method Ngoding
    {
        Console.WriteLine($"Ctak Ctak Ctak, error lagi!!");
    }
}

class ACER : Laptop
//ACER merupakan subclass dari Laptop
    {
    public ACER(string tipe_, Vga vga_, Processor processor_, string merk_ = "ACER") : base (merk_, tipe_, vga_, processor_)
        {

        }
    }
class Swift : ACER
//Swift merupakan subclass dari ACER
    {
    public Swift(Vga vga_, Processor processor_, string tipe_ = "Swift") : base(tipe_, vga_, processor_)
        {
        }
    }
class Predator : ACER
//Predator merupakan subclass dari ASUS
    {
        public Predator(Vga vga_, Processor processor_, string tipe_ = "Predator") : base(tipe_, vga_, processor_)
        {

        }
    public void BermainGame()
    //membuat method BermainGame
    {
        Console.WriteLine($"Laptop {merk} {tipe} sedang memainkan game");
    }
}

class Lenovo : Laptop
//Lenovo merupakan subclass dari Laptop
    {
        public Lenovo(string tipe_, Vga vga_, Processor processor_, string merk_ = "Lenovo") : base(merk_, tipe_, vga_, processor_)
        {

        }
    }
class Ideapad : Lenovo
//Ideapad merupakan subclass dari Lenovo
    {

        public Ideapad( Vga vga_, Processor processor_, string tipe_ = "Ideapad") : base(tipe_, vga_, processor_)
        {
        }
    }
class Legion : Lenovo
//Legion merupakan subclass dari Lenovo
    {
    public Legion( Vga vga_, Processor processor_, string tipe_ = "Legion") : base(tipe_, vga_, processor_)
        {

        }
    }


class Program
    {
        static void Main(string[] args)
        {
            amd amd = new amd();
            Corei7 corei7 = new Corei7();
            Predator predator = new Predator(amd,corei7);


            Laptop laptop1 = new Vivobook(new Nvidia(), new Corei5());
           
            Laptop laptop2 = new Ideapad(new amd(), new Ryzen());


            //No 1
            laptop2.LaptopDinyalakan();
            laptop2.LaptopDimatikan();

            //No 2
            //laptop1.Ngoding();

            //No 3
            Console.WriteLine($"LAPTOP 1. Merk vga_ {laptop1.vga.merk}, Merk processor_ {laptop1.processor.merk}, Tipe processor_ {laptop1.processor.tipe}");

            //No 4
            predator.BermainGame();

            //No 5
            ACER Acer = new Predator(amd, corei7);
            //Acer.BermainGame();

        }
    }
}