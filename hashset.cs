using System;
using System.Collections.Generic;

class KullaniciTablosu
{
    Dictionary<string, Kullanici> tablo = new Dictionary<string, Kullanici>();

    public void Ekle(string email, Kullanici kullanici)
    {
        if (!tablo.ContainsKey(email))
        {
            tablo[email] = kullanici;
            Console.WriteLine(" Eklendi: " + email);
        }
        else
        {
            Console.WriteLine("Bu e-posta zaten kayıtlı.");
        }
    }

    public void Goster(string email)
    {
        if (tablo.TryGetValue(email, out Kullanici k))
            Console.WriteLine("👤 " + k);
        else
            Console.WriteLine(" Kullanıcı bulunamadı.");
    }

    public void Sil(string email)
    {
        if (tablo.Remove(email))
            Console.WriteLine(" Silindi: " + email);
        else
            Console.WriteLine("E-posta bulunamadı.");
    }

    public void Listele()
    {
        Console.WriteLine("Kayıtlı Kullanıcılar:");
        foreach (var e in tablo)
        {
            Console.WriteLine($"{e.Key} → {e.Value}");
        }
    }
}
