namespace Part2
{
    public class ComplexNumber
    {
        private double realPart;
        private double imaginaryPart;

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            this.realPart = realPart;
            this.imaginaryPart = imaginaryPart;
        }
        public override string ToString()
        {
            return $"{realPart} + {imaginaryPart}i";
        }
        static public bool operator ==(ComplexNumber number1, ComplexNumber number2)
        {
            return ((number1.realPart == number2.realPart) && (number1.imaginaryPart == number2.imaginaryPart));
        }
        static public bool operator !=(ComplexNumber number1, ComplexNumber number2)
        {
            return ((number1.realPart != number2.realPart) || (number1.imaginaryPart != number2.imaginaryPart));
        }
        public override bool Equals(object obj)
        {
            if (obj is ComplexNumber number)
            {
                if ((realPart == number.realPart) && (imaginaryPart ==number.imaginaryPart))
                {
                    return true;
                }
            }
            return false;
        }
        public static ComplexNumber operator +(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.realPart + number2.realPart, number1.imaginaryPart + number2.imaginaryPart);
        }
        public static ComplexNumber operator -(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.realPart - number2.realPart, number1.imaginaryPart - number2.imaginaryPart);
        }
        public static ComplexNumber operator *(ComplexNumber number1, ComplexNumber number2)
        {
            return new ComplexNumber(number1.realPart * number2.realPart - number1.imaginaryPart * number2.imaginaryPart, number1.realPart * number2.imaginaryPart + number1.imaginaryPart * number2.realPart);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
