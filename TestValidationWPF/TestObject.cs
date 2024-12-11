namespace TestValidation {

    internal class TestObject {

        public string StringValue { get; set; }

        public int IntValue { get; set; }

        public decimal DecimalValue { get; set; }

        public double DoubleValue { get; set; }

        public TestObject(string stringValue, int intValue, decimal decimalValue, double doubleValue) {

            StringValue = stringValue;
            IntValue = intValue;
            DecimalValue = decimalValue;
            DoubleValue = doubleValue;
        }
    }
}