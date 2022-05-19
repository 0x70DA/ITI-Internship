using System;


namespace ConsoleApp1
{
    class Complex
    {
        int real, imag;
        double magnitude;
        public Complex(int real, int imag)
        {
            this.real = real;
            this.imag = imag;
            magnitude = Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imag, 2));
        }
        public int Real { get { return real; } set { real = value; } }
        public int Imag { get { return imag; } set { imag = value; } }
        public double Magnitude
        {
            get
            {
                return magnitude;
            }
        }
        public override string ToString()
        {
            if (Imag >= 0)
                return $"{Real}+{Imag}i";
            else
                return $"{Real}-{Imag}i";
        }

        #region Operator Overloading
        public static Complex operator +(Complex C1, Complex C2)
        {
            return new Complex(C1.real + C2.real, C1.imag + C2.imag);
        }
        public static Complex operator +(Complex C1, int num)
        {
            return new Complex(C1.real + num, C1.imag);
        }
        public static Complex operator ++(Complex C1)
        {
            return new Complex(C1.real + 1, C1.imag);
        }
        public static bool operator >(Complex C1, Complex C2)
        {
            return C1.magnitude > C2.magnitude;
        }
        public static bool operator <(Complex C1, Complex C2)
        {
            return C1.magnitude < C2.magnitude;
        }
        #endregion
    }
}
