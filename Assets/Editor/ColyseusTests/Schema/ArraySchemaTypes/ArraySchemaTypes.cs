// 
// THIS FILE HAS BEEN GENERATED AUTOMATICALLY
// DO NOT CHANGE IT MANUALLY UNLESS YOU KNOW WHAT YOU'RE DOING
// 
// GENERATED USING @colyseus/schema 1.0.0-alpha.42
// 

using Colyseus.Schema;

namespace SchemaTest.ArraySchemaTypes {
	public class ArraySchemaTypes : Schema {
		[Type(0, typeof(ArraySchema<IAmAChild>))]
		public ArraySchema<IAmAChild> arrayOfSchemas = new ArraySchema<IAmAChild>();

		[Type(1, typeof(ArraySchema<float>), "number")]
		public ArraySchema<float> arrayOfNumbers = new ArraySchema<float>();

		[Type(2, typeof(ArraySchema<string>), "string")]
		public ArraySchema<string> arrayOfStrings = new ArraySchema<string>();

		[Type(3, typeof(ArraySchema<int>), "int32")]
		public ArraySchema<int> arrayOfInt32 = new ArraySchema<int>();
	}
}
