using System;

  class class_pesawat
  {
    public string nama;
    private string newketinggian;

    public string ketinggian
    {
      get { return newketinggian; }
      set { newketinggian = value; }
    }

    public void terbang()
    {
      Console.WriteLine("Pesawat dengan nama {0}, sedang take off", this.nama);
    }

    public void sudahterbang() {
      Console.WriteLine("Pesawat sekarang berada pada ketinggian {0}", this.newketinggian);
    }
  }
