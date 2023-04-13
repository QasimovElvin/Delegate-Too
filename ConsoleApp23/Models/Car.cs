using System.Text;

namespace ConsoleApp23.Models;

internal class Car
{
	public int Id { get; }
	private string _name;

	public string Name
	{
		get { return _name; }
		set 
		{ 
			if(value.Length > 0)
			{
				_name = value;
			}
		}
	}
	private int _speed;

	public int Speed
	{
		get { return _speed; }
		set
		{
			if (value > 40)
			{
				_speed = value;
			}
		}
	}
	private int _price;

	public int Price
	{
		get { return _price; }
		set
		{
			if (value > 100)
			{
				_price = value;
			}
		}
	}
	public string Carcode;
	static int  IdCount = 0;
	static int CarCount = 1000;
	public Car( string name, int speed , int price )
	{
		StringBuilder stringBuilder=new StringBuilder();
		IdCount++;
		Id=IdCount;
		CarCount++;
		this.Name=name;
		this.Speed = speed;
		this.Price = price;
		stringBuilder.Append(name[0].ToString().ToUpper() + name[1].ToString().ToUpper()+CarCount.ToString());
		Carcode=stringBuilder.ToString();

		
	}

	public override string ToString()
	{
		return $"Name:{Name},Id:{Id},Price:{Price}, Speed:{Speed}, CarCode:{Carcode}";
	}

}
