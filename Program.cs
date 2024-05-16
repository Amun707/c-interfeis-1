namespace c_interfeis
{

    //Интерфейс - класс реализующий
    //абстрактные методы без визуализации, не имеет виртуальных и статических методов
    //не имеют реализации
    //не содержат полей, но могут содержать свойства
    //используются для полиморфизма
    //кроме методов и строк могут хранить дилегаты и события(ивенты)
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    //Cинтаксис создания интерфейса
    public interface IAbc
    {
    bool A {  get; set; }
    void Ab();
    }
    public interface Iworker
    {
        bool IsWorking { get; set; }
        string Work();
    }
    public class Driver : Iworker
    {
        public bool IsWorking { set; get; }
        public string Work()
        {
            return "Водитель работает";
        }
    }
    public class ManagerDriver : Iworker, IManager
    {
        List<Iworker> workers;   //ссылка (список объектов)
        public bool IsWorking { set; get; }
        public string Work()
        {
            return "Водитель работает";
        }
        public string Manager()
        {
            return "Управляет водителями";
        }
    }
    public interface IManager
    {
        public string Manager();
    }
    //Ознакомление с дженериками
    // IEnumerable   ( Сurent() return object), (MoveNext() return bool), (Reset()void),
    // (GetEnumerator() return IEnumerator) - перебиратель элементов коллекций
    //     IComporable - (CompareTo(object) return int) сравниваем схожие объекты
    //IComparer (Compare(object, object)) сравниваем схожие объекты
    //IClonable (Clone() return object) - позволяет клонировать объекты

}
