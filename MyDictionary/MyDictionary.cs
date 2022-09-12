public class MyDictionary<T, K>
{
    KeyValuePair<T, K>[] items; // int, string gibi bir veri tipidir.

	public MyDictionary()
	{
		items = new KeyValuePair<T, K>[0];
	}
	public void Add(T _key, K _value)
	{
		if (Control(_key))
		{
            Configuration();
            items[items.Length - 1] = new KeyValuePair<T, K>(_key, _value); // En son bize gelen değeri dizimize aktarıp işi bitirdik.
        }
		else
		{
			Console.WriteLine("Girdiğiniz key değeri özel olmalı. Yani daha önceden eklenmiş bir key değerini tekrardan kullanamassınız.");
		}
	}
	public void ShowList()
	{
		foreach (var item in items)
		{
			Console.WriteLine(item.Key+ " " + item.Value);
		}
	}
	public void Configuration()
	{
		KeyValuePair<T, K>[] tempArray = items; // geçiçi dizi
		items= new KeyValuePair<T,K>[items.Length + 1];
		for (int i = 0; i < tempArray.Length; i++)
		{
			items[i] = tempArray[i];// geçici dizideki elemanları alıp asıl dizimize gri koyduk.
        }
	}

    private bool Control(T _Key)
    {
        bool control = true;
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i].Key.ToString() == _Key.ToString())
            {
                control = false;
            }
        }
        return control;
    }
}