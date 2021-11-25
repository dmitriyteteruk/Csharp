using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise03_02_Vector
{
	class Vector
	{
		private double[] values;
		

		public Vector(int size = 0)
		{
			values = new double[size];
		}

		public Vector(double[] values)
		{
			this.values = values;
		}

		public void Append(double newValue)
		{
			double[] newValues = new double[values.Length + 1];
			for (int i = 0; i < values.Length; i++)
			{
				newValues[i] = values[i];
			}
			newValues[newValues.Length - 1] = newValue;
			values = newValues;
		}

		public int GetSize()
		{
			return values.Length;
		}

		public double GetElementAt(int index)
		{
			if (index < 0 || index >= values.Length)
			{
				throw new IndexOutOfRangeException("Index out of Vector's range");
			}
			return values[index];
		}

		// SetElement
		public double SetElementAt(int index)
		{
			if (index < 0 || index >= values.Length)
			{
				throw new IndexOutOfRangeException("Index out of Vector's range");
			}
			return values[index];
		}

		public Vector Add(Vector other)
		{
			if (values.Length != other.GetSize())
			{
				throw new Exception("Vectors have different sizes"); 
			}

			Vector resultVector = new Vector(values.Length);
			for (int i = 0; i < values.Length; i++)
			
			{
				resultVector.SetElementAt(i, values[i] + other.GetElementAt(i));
			}
			return resultVector;
		}

		//// add Substruckt
		
		//public Vector Multiply (double scalarValue)
		//{

		//}

		//// add Divide 
		//public Vector Divide (double scalarValue)
		//{

		//}

		public override string ToString()
		{
			StringBuilder stringBuilder_name = new StringBuilder("Vector elements are: ");
			for (int i = 0; i < values.Length; i++)
			{
				if (i != 0) stringBuilder_name.Append("; ");
				stringBuilder_name.Append(values[i]);
			}

			return stringBuilder_name.ToString();
		}
	}
}
