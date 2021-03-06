﻿using System;
using System.Linq.Expressions;
using System.Threading;

using JetBrains.Annotations;

namespace CodeJam.Arithmetic
{
	/// <summary>
	/// Callbacks for common arithmetic actions.
	/// Look at OperatorsPerformanceTest to see why.
	/// </summary>
	/// <typeparam name="T">The type of the operands.</typeparam>
	// IMPORTANT: DO NOT declare static .ctor on the type. The class should be marked as beforefieldinit.
	[PublicAPI]
	public static partial class Operators<T>
	{
		private const LazyThreadSafetyMode _lazyMode = LazyThreadSafetyMode.PublicationOnly;

		private static readonly Lazy<Func<T, T, int>> _compare = Lazy.Create(OperatorsFactory.Comparison<T>, _lazyMode);

		/// <summary>
		/// Comparison callback
		/// </summary>
		[NotNull]
		public static Func<T, T, int> Compare => _compare.Value;

		#region Special fields
		private static readonly Lazy<bool> _hasNaN =
			new Lazy<bool>(OperatorsFactory.HasNaN<T>, _lazyMode);

		/// <summary>
		/// Check for the NaN value.
		/// </summary>
		public static bool HasNaN => _hasNaN.Value;

		private static readonly Lazy<T> _naN =
			new Lazy<T>(OperatorsFactory.GetNaN<T>, _lazyMode);

		/// <summary>
		/// NaN value
		/// </summary>
		[NotNull]
		public static T NaN => _naN.Value;
		
		private static readonly Lazy<bool> _hasNegativeInfinity =
			new Lazy<bool>(OperatorsFactory.HasNegativeInfinity<T>, _lazyMode);

		/// <summary>
		/// Check for the negative infinity value.
		/// </summary>
		public static bool HasNegativeInfinity => _hasNegativeInfinity.Value;

		private static readonly Lazy<T> _negativeInfinity =
			new Lazy<T>(OperatorsFactory.GetNegativeInfinity<T>, _lazyMode);

		/// <summary>
		/// Negative infinity value
		/// </summary>
		[NotNull]
		public static T NegativeInfinity => _negativeInfinity.Value;

		private static readonly Lazy<bool> _hasPositiveInfinity =
			new Lazy<bool>(OperatorsFactory.HasPositiveInfinity<T>, _lazyMode);

		/// <summary>
		/// Check for the positive infinity value.
		/// </summary>
		public static bool HasPositiveInfinity => _hasPositiveInfinity.Value;

		private static readonly Lazy<T> _positiveInfinity =
			new Lazy<T>(OperatorsFactory.GetPositiveInfinity<T>, _lazyMode);

		/// <summary>
		/// Positive infinity value
		/// </summary>
		[NotNull]
		public static T PositiveInfinity => _positiveInfinity.Value;
		#endregion

		#region Custom impl for _onesComplement (FW 3.5 targeting)
		/// <summary>OnesComplement operator factory.</summary>
		private static readonly Lazy<Func<T, T>> _onesComplement =
#if FW35
			new Lazy<Func<T, T>>(() => OperatorsFactory.UnaryOperator<T>(ExpressionType.Not), _lazyMode);
#else
			new Lazy<Func<T, T>>(() => OperatorsFactory.UnaryOperator<T>(ExpressionType.OnesComplement), _lazyMode);
#endif

		/// <summary>OnesComplement operator.</summary>
		/// <value>The OnesComplement operator.</value>
		[NotNull]
		public static Func<T, T> OnesComplement => _onesComplement.Value;
		#endregion
	}
}