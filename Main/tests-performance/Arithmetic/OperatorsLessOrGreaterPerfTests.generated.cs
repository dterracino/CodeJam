﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CodeJam.PerfTests;

using NUnit.Framework;

namespace CodeJam.Arithmetic
{
	[TestFixture(Category = CompetitionHelpers.PerfTestCategory + ": Operators<T>.LessOrGreater")]
	[CompetitionXmlAnnotation("CodeJam.Arithmetic.OperatorsLessOrGreaterPerfTests.generated.xml")]
	[Explicit(CompetitionHelpers.TemporarilyExcludedReason)]
	public class OperatorsLessOrGreaterPerfTests
	{
		#region GreaterThan
		[Test]
		public void RunIntGreaterThanCase() =>
			Competition.Run<IntGreaterThanCase>();

		[CompetitionBurstMode]
		public class IntGreaterThanCase : IntOperatorsBaseCase
		{
			private static readonly Func<int, int, bool> _opGreaterThan = Operators<int>.GreaterThan;
			private static readonly Func<int, int, bool> _emittedGreaterThan = (a, b) => a > b;
			private static readonly Comparer<int> _comparer = Comparer<int>.Default;

			[CompetitionBaseline]
			public bool Test00GreaterThanBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a > b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01GreaterThanOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opGreaterThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02GreaterThanEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedGreaterThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])> 0;
				return result;
			}
		}

		[Test]
		public void RunNullableIntGreaterThanCase() =>
			Competition.Run<NullableIntGreaterThanCase>();

		[CompetitionBurstMode]
		public class NullableIntGreaterThanCase : NullableIntOperatorsBaseCase
		{
			private static readonly Func<int?, int?, bool> _opGreaterThan = Operators<int?>.GreaterThan;
			private static readonly Func<int?, int?, bool> _emittedGreaterThan = (a, b) => a > b;
			private static readonly Comparer<int?> _comparer = Comparer<int?>.Default;

			[CompetitionBaseline]
			public bool Test00GreaterThanBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a > b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01GreaterThanOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opGreaterThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02GreaterThanEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedGreaterThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])> 0;
				return result;
			}
		}

		[Test]
		public void RunEnumGreaterThanCase() =>
			Competition.Run<EnumGreaterThanCase>();

		[CompetitionBurstMode]
		public class EnumGreaterThanCase : EnumOperatorsBaseCase
		{
			private static readonly Func<AttributeTargets, AttributeTargets, bool> _opGreaterThan = Operators<AttributeTargets>.GreaterThan;
			private static readonly Func<AttributeTargets, AttributeTargets, bool> _emittedGreaterThan = (a, b) => a > b;
			private static readonly Comparer<AttributeTargets> _comparer = Comparer<AttributeTargets>.Default;

			[CompetitionBaseline]
			public bool Test00GreaterThanBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a > b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01GreaterThanOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opGreaterThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02GreaterThanEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedGreaterThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])> 0;
				return result;
			}
		}

		[Test]
		public void RunNullableEnumGreaterThanCase() =>
			Competition.Run<NullableEnumGreaterThanCase>();

		[CompetitionBurstMode]
		public class NullableEnumGreaterThanCase : NullableEnumOperatorsBaseCase
		{
			private static readonly Func<AttributeTargets?, AttributeTargets?, bool> _opGreaterThan = Operators<AttributeTargets?>.GreaterThan;
			private static readonly Func<AttributeTargets?, AttributeTargets?, bool> _emittedGreaterThan = (a, b) => a > b;
			private static readonly Comparer<AttributeTargets?> _comparer = Comparer<AttributeTargets?>.Default;

			[CompetitionBaseline]
			public bool Test00GreaterThanBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a > b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01GreaterThanOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opGreaterThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02GreaterThanEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedGreaterThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])> 0;
				return result;
			}
		}

		[Test]
		public void RunNullableDateTimeGreaterThanCase() =>
			Competition.Run<NullableDateTimeGreaterThanCase>();

		[CompetitionBurstMode]
		public class NullableDateTimeGreaterThanCase : NullableDateTimeOperatorsBaseCase
		{
			private static readonly Func<DateTime?, DateTime?, bool> _opGreaterThan = Operators<DateTime?>.GreaterThan;
			private static readonly Func<DateTime?, DateTime?, bool> _emittedGreaterThan = (a, b) => a > b;
			private static readonly Comparer<DateTime?> _comparer = Comparer<DateTime?>.Default;

			[CompetitionBaseline]
			public bool Test00GreaterThanBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a > b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01GreaterThanOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opGreaterThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02GreaterThanEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedGreaterThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])> 0;
				return result;
			}
		}

		[Test]
		public void RunStringGreaterThanCase() =>
			Competition.Run<StringGreaterThanCase>();

		[CompetitionBurstMode]
		public class StringGreaterThanCase : StringOperatorsBaseCase
		{
			private static readonly Func<string, string, bool> _opGreaterThan = Operators<string>.GreaterThan;
			private static readonly Func<string, string, bool> _emittedGreaterThan = (a, b) => string.CompareOrdinal(a, b) > 0;
			private static readonly Comparer<string> _comparer = Comparer<string>.Default;

			[CompetitionBaseline]
			public bool Test00GreaterThanBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = string.CompareOrdinal(a, b) > 0;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01GreaterThanOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opGreaterThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02GreaterThanEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedGreaterThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])> 0;
				return result;
			}
		}
		#endregion

		#region GreaterThanOrEqual
		[Test]
		public void RunIntGreaterThanOrEqualCase() =>
			Competition.Run<IntGreaterThanOrEqualCase>();

		[CompetitionBurstMode]
		public class IntGreaterThanOrEqualCase : IntOperatorsBaseCase
		{
			private static readonly Func<int, int, bool> _opGreaterThanOrEqual = Operators<int>.GreaterThanOrEqual;
			private static readonly Func<int, int, bool> _emittedGreaterThanOrEqual = (a, b) => a >= b;
			private static readonly Comparer<int> _comparer = Comparer<int>.Default;

			[CompetitionBaseline]
			public bool Test00GreaterThanOrEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a >= b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01GreaterThanOrEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opGreaterThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02GreaterThanOrEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedGreaterThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])>= 0;
				return result;
			}
		}

		[Test]
		public void RunNullableIntGreaterThanOrEqualCase() =>
			Competition.Run<NullableIntGreaterThanOrEqualCase>();

		[CompetitionBurstMode]
		public class NullableIntGreaterThanOrEqualCase : NullableIntOperatorsBaseCase
		{
			private static readonly Func<int?, int?, bool> _opGreaterThanOrEqual = Operators<int?>.GreaterThanOrEqual;
			private static readonly Func<int?, int?, bool> _emittedGreaterThanOrEqual = (a, b) => a >= b;
			private static readonly Comparer<int?> _comparer = Comparer<int?>.Default;

			[CompetitionBaseline]
			public bool Test00GreaterThanOrEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a >= b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01GreaterThanOrEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opGreaterThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02GreaterThanOrEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedGreaterThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])>= 0;
				return result;
			}
		}

		[Test]
		public void RunEnumGreaterThanOrEqualCase() =>
			Competition.Run<EnumGreaterThanOrEqualCase>();

		[CompetitionBurstMode]
		public class EnumGreaterThanOrEqualCase : EnumOperatorsBaseCase
		{
			private static readonly Func<AttributeTargets, AttributeTargets, bool> _opGreaterThanOrEqual = Operators<AttributeTargets>.GreaterThanOrEqual;
			private static readonly Func<AttributeTargets, AttributeTargets, bool> _emittedGreaterThanOrEqual = (a, b) => a >= b;
			private static readonly Comparer<AttributeTargets> _comparer = Comparer<AttributeTargets>.Default;

			[CompetitionBaseline]
			public bool Test00GreaterThanOrEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a >= b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01GreaterThanOrEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opGreaterThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02GreaterThanOrEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedGreaterThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])>= 0;
				return result;
			}
		}

		[Test]
		public void RunNullableEnumGreaterThanOrEqualCase() =>
			Competition.Run<NullableEnumGreaterThanOrEqualCase>();

		[CompetitionBurstMode]
		public class NullableEnumGreaterThanOrEqualCase : NullableEnumOperatorsBaseCase
		{
			private static readonly Func<AttributeTargets?, AttributeTargets?, bool> _opGreaterThanOrEqual = Operators<AttributeTargets?>.GreaterThanOrEqual;
			private static readonly Func<AttributeTargets?, AttributeTargets?, bool> _emittedGreaterThanOrEqual = (a, b) => a >= b;
			private static readonly Comparer<AttributeTargets?> _comparer = Comparer<AttributeTargets?>.Default;

			[CompetitionBaseline]
			public bool Test00GreaterThanOrEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a >= b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01GreaterThanOrEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opGreaterThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02GreaterThanOrEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedGreaterThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])>= 0;
				return result;
			}
		}

		[Test]
		public void RunNullableDateTimeGreaterThanOrEqualCase() =>
			Competition.Run<NullableDateTimeGreaterThanOrEqualCase>();

		[CompetitionBurstMode]
		public class NullableDateTimeGreaterThanOrEqualCase : NullableDateTimeOperatorsBaseCase
		{
			private static readonly Func<DateTime?, DateTime?, bool> _opGreaterThanOrEqual = Operators<DateTime?>.GreaterThanOrEqual;
			private static readonly Func<DateTime?, DateTime?, bool> _emittedGreaterThanOrEqual = (a, b) => a >= b;
			private static readonly Comparer<DateTime?> _comparer = Comparer<DateTime?>.Default;

			[CompetitionBaseline]
			public bool Test00GreaterThanOrEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a >= b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01GreaterThanOrEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opGreaterThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02GreaterThanOrEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedGreaterThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])>= 0;
				return result;
			}
		}

		[Test]
		public void RunStringGreaterThanOrEqualCase() =>
			Competition.Run<StringGreaterThanOrEqualCase>();

		[CompetitionBurstMode]
		public class StringGreaterThanOrEqualCase : StringOperatorsBaseCase
		{
			private static readonly Func<string, string, bool> _opGreaterThanOrEqual = Operators<string>.GreaterThanOrEqual;
			private static readonly Func<string, string, bool> _emittedGreaterThanOrEqual = (a, b) => string.CompareOrdinal(a, b) >= 0;
			private static readonly Comparer<string> _comparer = Comparer<string>.Default;

			[CompetitionBaseline]
			public bool Test00GreaterThanOrEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = string.CompareOrdinal(a, b) >= 0;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01GreaterThanOrEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opGreaterThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02GreaterThanOrEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedGreaterThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])>= 0;
				return result;
			}
		}
		#endregion

		#region LessThan
		[Test]
		public void RunIntLessThanCase() =>
			Competition.Run<IntLessThanCase>();

		[CompetitionBurstMode]
		public class IntLessThanCase : IntOperatorsBaseCase
		{
			private static readonly Func<int, int, bool> _opLessThan = Operators<int>.LessThan;
			private static readonly Func<int, int, bool> _emittedLessThan = (a, b) => a < b;
			private static readonly Comparer<int> _comparer = Comparer<int>.Default;

			[CompetitionBaseline]
			public bool Test00LessThanBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a < b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01LessThanOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opLessThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02LessThanEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedLessThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])< 0;
				return result;
			}
		}

		[Test]
		public void RunNullableIntLessThanCase() =>
			Competition.Run<NullableIntLessThanCase>();

		[CompetitionBurstMode]
		public class NullableIntLessThanCase : NullableIntOperatorsBaseCase
		{
			private static readonly Func<int?, int?, bool> _opLessThan = Operators<int?>.LessThan;
			private static readonly Func<int?, int?, bool> _emittedLessThan = (a, b) => a < b;
			private static readonly Comparer<int?> _comparer = Comparer<int?>.Default;

			[CompetitionBaseline]
			public bool Test00LessThanBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a < b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01LessThanOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opLessThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02LessThanEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedLessThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])< 0;
				return result;
			}
		}

		[Test]
		public void RunEnumLessThanCase() =>
			Competition.Run<EnumLessThanCase>();

		[CompetitionBurstMode]
		public class EnumLessThanCase : EnumOperatorsBaseCase
		{
			private static readonly Func<AttributeTargets, AttributeTargets, bool> _opLessThan = Operators<AttributeTargets>.LessThan;
			private static readonly Func<AttributeTargets, AttributeTargets, bool> _emittedLessThan = (a, b) => a < b;
			private static readonly Comparer<AttributeTargets> _comparer = Comparer<AttributeTargets>.Default;

			[CompetitionBaseline]
			public bool Test00LessThanBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a < b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01LessThanOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opLessThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02LessThanEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedLessThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])< 0;
				return result;
			}
		}

		[Test]
		public void RunNullableEnumLessThanCase() =>
			Competition.Run<NullableEnumLessThanCase>();

		[CompetitionBurstMode]
		public class NullableEnumLessThanCase : NullableEnumOperatorsBaseCase
		{
			private static readonly Func<AttributeTargets?, AttributeTargets?, bool> _opLessThan = Operators<AttributeTargets?>.LessThan;
			private static readonly Func<AttributeTargets?, AttributeTargets?, bool> _emittedLessThan = (a, b) => a < b;
			private static readonly Comparer<AttributeTargets?> _comparer = Comparer<AttributeTargets?>.Default;

			[CompetitionBaseline]
			public bool Test00LessThanBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a < b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01LessThanOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opLessThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02LessThanEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedLessThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])< 0;
				return result;
			}
		}

		[Test]
		public void RunNullableDateTimeLessThanCase() =>
			Competition.Run<NullableDateTimeLessThanCase>();

		[CompetitionBurstMode]
		public class NullableDateTimeLessThanCase : NullableDateTimeOperatorsBaseCase
		{
			private static readonly Func<DateTime?, DateTime?, bool> _opLessThan = Operators<DateTime?>.LessThan;
			private static readonly Func<DateTime?, DateTime?, bool> _emittedLessThan = (a, b) => a < b;
			private static readonly Comparer<DateTime?> _comparer = Comparer<DateTime?>.Default;

			[CompetitionBaseline]
			public bool Test00LessThanBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a < b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01LessThanOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opLessThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02LessThanEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedLessThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])< 0;
				return result;
			}
		}

		[Test]
		public void RunStringLessThanCase() =>
			Competition.Run<StringLessThanCase>();

		[CompetitionBurstMode]
		public class StringLessThanCase : StringOperatorsBaseCase
		{
			private static readonly Func<string, string, bool> _opLessThan = Operators<string>.LessThan;
			private static readonly Func<string, string, bool> _emittedLessThan = (a, b) => string.CompareOrdinal(a, b) < 0;
			private static readonly Comparer<string> _comparer = Comparer<string>.Default;

			[CompetitionBaseline]
			public bool Test00LessThanBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = string.CompareOrdinal(a, b) < 0;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01LessThanOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opLessThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02LessThanEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedLessThan(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])< 0;
				return result;
			}
		}
		#endregion

		#region LessThanOrEqual
		[Test]
		public void RunIntLessThanOrEqualCase() =>
			Competition.Run<IntLessThanOrEqualCase>();

		[CompetitionBurstMode]
		public class IntLessThanOrEqualCase : IntOperatorsBaseCase
		{
			private static readonly Func<int, int, bool> _opLessThanOrEqual = Operators<int>.LessThanOrEqual;
			private static readonly Func<int, int, bool> _emittedLessThanOrEqual = (a, b) => a <= b;
			private static readonly Comparer<int> _comparer = Comparer<int>.Default;

			[CompetitionBaseline]
			public bool Test00LessThanOrEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a <= b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01LessThanOrEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opLessThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02LessThanOrEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedLessThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])<= 0;
				return result;
			}
		}

		[Test]
		public void RunNullableIntLessThanOrEqualCase() =>
			Competition.Run<NullableIntLessThanOrEqualCase>();

		[CompetitionBurstMode]
		public class NullableIntLessThanOrEqualCase : NullableIntOperatorsBaseCase
		{
			private static readonly Func<int?, int?, bool> _opLessThanOrEqual = Operators<int?>.LessThanOrEqual;
			private static readonly Func<int?, int?, bool> _emittedLessThanOrEqual = (a, b) => a <= b;
			private static readonly Comparer<int?> _comparer = Comparer<int?>.Default;

			[CompetitionBaseline]
			public bool Test00LessThanOrEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a <= b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01LessThanOrEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opLessThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02LessThanOrEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedLessThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])<= 0;
				return result;
			}
		}

		[Test]
		public void RunEnumLessThanOrEqualCase() =>
			Competition.Run<EnumLessThanOrEqualCase>();

		[CompetitionBurstMode]
		public class EnumLessThanOrEqualCase : EnumOperatorsBaseCase
		{
			private static readonly Func<AttributeTargets, AttributeTargets, bool> _opLessThanOrEqual = Operators<AttributeTargets>.LessThanOrEqual;
			private static readonly Func<AttributeTargets, AttributeTargets, bool> _emittedLessThanOrEqual = (a, b) => a <= b;
			private static readonly Comparer<AttributeTargets> _comparer = Comparer<AttributeTargets>.Default;

			[CompetitionBaseline]
			public bool Test00LessThanOrEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a <= b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01LessThanOrEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opLessThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02LessThanOrEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedLessThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])<= 0;
				return result;
			}
		}

		[Test]
		public void RunNullableEnumLessThanOrEqualCase() =>
			Competition.Run<NullableEnumLessThanOrEqualCase>();

		[CompetitionBurstMode]
		public class NullableEnumLessThanOrEqualCase : NullableEnumOperatorsBaseCase
		{
			private static readonly Func<AttributeTargets?, AttributeTargets?, bool> _opLessThanOrEqual = Operators<AttributeTargets?>.LessThanOrEqual;
			private static readonly Func<AttributeTargets?, AttributeTargets?, bool> _emittedLessThanOrEqual = (a, b) => a <= b;
			private static readonly Comparer<AttributeTargets?> _comparer = Comparer<AttributeTargets?>.Default;

			[CompetitionBaseline]
			public bool Test00LessThanOrEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a <= b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01LessThanOrEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opLessThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02LessThanOrEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedLessThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])<= 0;
				return result;
			}
		}

		[Test]
		public void RunNullableDateTimeLessThanOrEqualCase() =>
			Competition.Run<NullableDateTimeLessThanOrEqualCase>();

		[CompetitionBurstMode]
		public class NullableDateTimeLessThanOrEqualCase : NullableDateTimeOperatorsBaseCase
		{
			private static readonly Func<DateTime?, DateTime?, bool> _opLessThanOrEqual = Operators<DateTime?>.LessThanOrEqual;
			private static readonly Func<DateTime?, DateTime?, bool> _emittedLessThanOrEqual = (a, b) => a <= b;
			private static readonly Comparer<DateTime?> _comparer = Comparer<DateTime?>.Default;

			[CompetitionBaseline]
			public bool Test00LessThanOrEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = a <= b;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01LessThanOrEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opLessThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02LessThanOrEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedLessThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])<= 0;
				return result;
			}
		}

		[Test]
		public void RunStringLessThanOrEqualCase() =>
			Competition.Run<StringLessThanOrEqualCase>();

		[CompetitionBurstMode]
		public class StringLessThanOrEqualCase : StringOperatorsBaseCase
		{
			private static readonly Func<string, string, bool> _opLessThanOrEqual = Operators<string>.LessThanOrEqual;
			private static readonly Func<string, string, bool> _emittedLessThanOrEqual = (a, b) => string.CompareOrdinal(a, b) <= 0;
			private static readonly Comparer<string> _comparer = Comparer<string>.Default;

			[CompetitionBaseline]
			public bool Test00LessThanOrEqualBaseline()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
				{
					var a = ValuesA[i];
					var b = ValuesB[i];
					result = string.CompareOrdinal(a, b) <= 0;
				}
				return result;
			}

			[CompetitionBenchmark]
			public bool Test01LessThanOrEqualOperator()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _opLessThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test02LessThanOrEqualEmitted()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _emittedLessThanOrEqual(ValuesA[i], ValuesB[i]);
				return result;
			}

			[CompetitionBenchmark]
			public bool Test03Comparer()
			{
				var result = default(bool);
				for (var i = 0; i < ValuesB.Length; i++)
					result = _comparer.Compare(ValuesA[i], ValuesB[i])<= 0;
				return result;
			}
		}
		#endregion
	}
}