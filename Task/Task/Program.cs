

using Task;

//IntList list = new IntList();

//list.Add(1);
//list.Add(2);
//list.Add(3);

//var result = list.GetAll();

//foreach (var item in result)
//{
//    Console.WriteLine(item);
//}


//DataList<int> datas = new DataList<int>();

//datas.Add(1);
//datas.Add(2);
//datas.Add(3);
//datas.Add(4);

//var result = datas.GetAll();

//foreach (var item in result)
//    Console.WriteLine(item);

//DataList<string> dataList = new DataList<string>();

//dataList.Add("salam");
//dataList.Add("sagol");

//var result2 = dataList.GetAll();

//foreach (var item in result2)
//{
//    Console.WriteLine(item);
//}



//DataList<bool> dataList2 = new DataList<bool>();

//dataList2.Add(true);
//dataList2.Add(false);
//dataList2.Add(true);

//var result3 = dataList2.GetAll();

//foreach (var item in result3)
//{
//    Console.WriteLine(item);
//}



DataList<string> dataList = new DataList<string>();

dataList.Add("salam");
dataList.Add("sagol");
dataList.Add("hello");
dataList.Add("salam");
dataList.Add("salam");


dataList.Delete("sagol");

var result = dataList.GetAll();

foreach (var item in result)
{
    Console.WriteLine(item);
}



