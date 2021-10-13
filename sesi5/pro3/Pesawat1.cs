using System;

  class pesawat_tempur:pesawat
  {
    public void terbang()
    {
      Console.WriteLine("Pesawat tempur dengan nama {0}, yang mempunyai junlah roda {1}, sedang berada pada ketinggian{2} dengan membawa jumlah penumpang sebanyak {3} Akan meledakan senjata", this.Nama, this.JumlahRoda, this.Ketinggian, this.JumlahPenumpang);
    }
  }

