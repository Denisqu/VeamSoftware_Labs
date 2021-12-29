namespace VeamSoftware_Labs.Veam_module_1.lb1
{
    public class MyImmutableType
    {
        private readonly int _a;
        public int A => _a;

        public MyImmutableType(int a)
        {
            _a = a;
        }

        public MyImmutableType ChangeA(int newA)
        {
            return new MyImmutableType(newA);
        }

        public override string ToString()
        {
            return _a.ToString();
        }

    }
}