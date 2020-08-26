using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11Project
{
    class MathClass
    {    
        int AnswerByte = 0;
        int AnswerShort = 0;
        int AnswerInt = 0;
        long AnswerLong = 0;
        Single AnswerFloat = 0;
        double AnswerDouble = 0;
        decimal AnswerDecimal = 0.0m;

        // Byte
        public long ByteOperationADD(byte incLeft, byte incRight)
        {
            long FinalAnswer = 0;
            AnswerByte = incLeft + incRight;
            FinalAnswer = Convert.ToInt64(AnswerByte);

            return (FinalAnswer);
        }

        public long ByteOperationMINUS(byte incLeft, byte incRight)
        {
            long FinalAnswer = 0;
            AnswerByte = incLeft - incRight;
            FinalAnswer = Convert.ToByte(AnswerByte);

            return (FinalAnswer);
        }

        public long ByteOperationMULTIPLY(byte incLeft, byte incRight)
        {
            long FinalAnswer = 0;
            AnswerByte = incLeft * incRight;
            FinalAnswer = Convert.ToInt64(AnswerByte);

            return (FinalAnswer);
        }

        public long ByteOperationDIVISION(byte incLeft, byte incRight)
        {
            long FinalAnswer = 0;
            AnswerByte = incLeft / incRight;
            FinalAnswer = Convert.ToInt64(AnswerByte);

            return (FinalAnswer);
        }

        public long ByteOperationMODULUS(byte incLeft, byte incRight)
        {
            long FinalAnswer = 0;
            AnswerByte = incLeft % incRight;
            FinalAnswer = Convert.ToInt64(AnswerByte);

            return (FinalAnswer);
        }

        //Short
        public long ShortOperationADD(short incLeft, short incRight)
        {
            long FinalAnswer = 0;
            AnswerShort = incLeft + incRight;
            FinalAnswer = Convert.ToInt64(AnswerShort);

            return (FinalAnswer);
        }

        public long ShortOperationMINUS(short incLeft, short incRight)
        {
            long FinalAnswer = 0;
            AnswerShort = incLeft - incRight;
            FinalAnswer = Convert.ToInt64(AnswerShort);

            return (FinalAnswer);
        }

        public long ShortOperationMULTIPLY(short incLeft, short incRight)
        {
            long FinalAnswer = 0;
            AnswerShort = incLeft * incRight;
            FinalAnswer = Convert.ToInt64(AnswerShort);

            return (FinalAnswer);
        }

        public long ShortOperationDIVISION(short incLeft, short incRight)
        {
            long FinalAnswer = 0;
            AnswerShort = incLeft / incRight;
            FinalAnswer = Convert.ToInt64(AnswerShort);

            return (FinalAnswer);
        }

        public long ShortOperationMODULUS(short incLeft, short incRight)
        {
            long FinalAnswer = 0;
            AnswerShort = incLeft % incRight;
            FinalAnswer = Convert.ToInt64(AnswerShort);

            return (FinalAnswer);
        }

        //Int
        public long IntOperationADD(int incLeft, int incRight)
        {
            long FinalAnswer = 0;
            AnswerInt = incLeft + incRight;
            FinalAnswer = Convert.ToInt64(AnswerInt);

            return (FinalAnswer);
        }

        public long IntOperationMINUS(int incLeft, int incRight)
        {
            long FinalAnswer = 0;
            AnswerInt = incLeft - incRight;
            FinalAnswer = Convert.ToInt64(AnswerInt);

            return (FinalAnswer);
        }

        public long IntOperationMULTIPLY(int incLeft, int incRight)
        {
            long FinalAnswer = 0;
            AnswerInt = incLeft * incRight;
            FinalAnswer = Convert.ToInt64(AnswerInt);

            return (FinalAnswer);
        }

        public long IntOperationDIVISION(int incLeft, int incRight)
        {
            long FinalAnswer = 0;
            AnswerInt = incLeft / incRight;
            FinalAnswer = Convert.ToInt64(AnswerInt);

            return (FinalAnswer);
        }

        public long IntOperationMODULUS(int incLeft, int incRight)
        {
            long FinalAnswer = 0;
            AnswerInt = incLeft % incRight;
            FinalAnswer = Convert.ToInt64(AnswerInt);

            return (FinalAnswer);
        }

        //Long
        public long LongOperationADD(long incLeft, long incRight)
        {
            long FinalAnswer = 0;
            AnswerLong = incLeft + incRight;
            FinalAnswer = Convert.ToInt64(AnswerLong);

            return (FinalAnswer);
        }

        public long LongOperationMINUS(long incLeft, long incRight)
        {
            long FinalAnswer = 0;
            AnswerLong = incLeft - incRight;
            FinalAnswer = Convert.ToInt64(AnswerLong);

            return (FinalAnswer);
        }

        public long LongOperationMULTIPLY(long incLeft, long incRight)
        {
            long FinalAnswer = 0;
            AnswerLong = incLeft * incRight;
            FinalAnswer = Convert.ToInt64(AnswerLong);

            return (FinalAnswer);
        }

        public long LongOperationDIVISION(long incLeft, long incRight)
        {
            long FinalAnswer = 0;
            AnswerLong = incLeft / incRight;
            FinalAnswer = Convert.ToInt64(AnswerLong);

            return (FinalAnswer);
        }

        public long LongOperationMODULUS(long incLeft, long incRight)
        {
            long FinalAnswer = 0;
            AnswerLong = incLeft % incRight;
            FinalAnswer = Convert.ToInt64(AnswerLong);

            return (FinalAnswer);
        }

        //Float
        public decimal FloatOperationADD(Single incLeft, Single incRight)
        {
            decimal FinalAnswer = 0.0m;
            AnswerFloat = incLeft + incRight;
            FinalAnswer = Convert.ToDecimal(AnswerFloat);

            return (FinalAnswer);
        }

        public decimal FloatOperationMINUS(Single incLeft, Single incRight)
        {
            decimal FinalAnswer = 0.0m;
            AnswerFloat = incLeft - incRight;
            FinalAnswer = Convert.ToDecimal(AnswerFloat);

            return (FinalAnswer);
        }

        public decimal FloatOperationMULTIPLY(Single incLeft, Single incRight)
        {
            decimal FinalAnswer = 0.0m;
            AnswerFloat = incLeft * incRight;
            FinalAnswer = Convert.ToDecimal(AnswerFloat);

            return (FinalAnswer);
        }

        public decimal FloatOperationDIVISION(Single incLeft, Single incRight)
        {
            decimal FinalAnswer = 0;
            AnswerFloat = incLeft / incRight;
            FinalAnswer = Convert.ToDecimal(AnswerFloat);

            return (FinalAnswer);
        }

        public decimal FloatOperationMODULUS(Single incLeft, Single incRight)
        {
            decimal FinalAnswer = 0;
            AnswerFloat = incLeft % incRight;
            FinalAnswer = Convert.ToDecimal(AnswerFloat);

            return (FinalAnswer);
        }


        // Double
        public decimal DoubleOperationADD(double incLeft, double incRight)
        {
            decimal FinalAnswer = 0;
            AnswerDouble = incLeft + incRight;
            FinalAnswer = Convert.ToDecimal(AnswerDouble);

            return (FinalAnswer);
        }

        public decimal DoubleOperationMINUS(double incLeft, double incRight)
        {
            decimal FinalAnswer = 0;
            AnswerDouble = incLeft - incRight;
            FinalAnswer = Convert.ToDecimal(AnswerDouble);

            return (FinalAnswer);
        }

        public decimal DoubleOperationMULTIPLY(double incLeft, double incRight)
        {
            decimal FinalAnswer = 0;
            AnswerDouble = incLeft * incRight;
            FinalAnswer = Convert.ToDecimal(AnswerDouble);

            return (FinalAnswer);
        }

        public decimal DoubleOperationDIVISION(double incLeft, double incRight)
        {
            decimal FinalAnswer = 0;
            AnswerDouble = incLeft / incRight;
            FinalAnswer = Convert.ToDecimal(AnswerDouble);

            return (FinalAnswer);
        }

        public decimal DoubleOperationMODULUS(double incLeft, double incRight)
        {
            decimal FinalAnswer = 0;
            AnswerDouble = incLeft % incRight;
            FinalAnswer = Convert.ToDecimal(AnswerDouble);

            return (FinalAnswer);
        }

        //Decimal
        public decimal DecimalOperationADD(decimal incLeft, decimal incRight)
        {
            decimal FinalAnswer = 0;
            AnswerDecimal = incLeft + incRight;
            FinalAnswer = Convert.ToDecimal(AnswerDecimal);

            return (FinalAnswer);
        }

        public decimal DecimalOperationMINUS(decimal incLeft, decimal incRight)
        {
            decimal FinalAnswer = 0;
            AnswerDecimal = incLeft - incRight;
            FinalAnswer = Convert.ToDecimal(AnswerDecimal);

            return (FinalAnswer);


        }

        public decimal DecimalOperationMULTIPLY(decimal incLeft, decimal incRight)
        {
            decimal FinalAnswer = 0;
            AnswerDecimal = incLeft * incRight;
            FinalAnswer = Convert.ToDecimal(AnswerDecimal);

            return (FinalAnswer);
        }

        public decimal DecimalOperationDIVISION(decimal incLeft, decimal incRight)
        {
            decimal FinalAnswer = 0;
            AnswerDecimal = incLeft / incRight;
            FinalAnswer = Convert.ToDecimal(AnswerDecimal);
            

            return (FinalAnswer);
        }

        public decimal DecimalOperationMODULUS(decimal incLeft, decimal incRight)
        {
            decimal FinalAnswer = 0;
            AnswerDecimal = incLeft % incRight;
            FinalAnswer = Convert.ToDecimal(AnswerDecimal);
            
            return (FinalAnswer);
        }
    }

}
  

