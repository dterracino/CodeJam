﻿using System;
using System.Collections.Generic;

using JetBrains.Annotations;

namespace CodeJam.Collections
{
	/// <summary>
	/// Represents an element associated with its index in a sequence.
	/// </summary>
	[PublicAPI]
	public struct IndexedItem<T> : IEquatable<IndexedItem<T>>
	{
		/// <summary>
		/// Gets the value of the element.
		/// </summary>
		/// <returns>
		/// The value of the element.
		/// </returns>
		public T Item { get; }

		/// <summary>
		/// Gets the index of the element in a sequence.
		/// </summary>
		/// <returns>
		/// The index of the element in a sequence.
		/// </returns>
		public int Index { get; }

		/// <summary>
		/// Determines if the value is first in a sequence.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this instance is first; otherwise, <c>false</c>.
		/// </returns>
		public bool IsFirst { get; }

		/// <summary>
		/// Determines if the value is last in a sequence.
		/// </summary>
		/// <returns>
		/// <c>true</c> if this instance is last; otherwise, <c>false</c>.
		/// </returns>
		public bool IsLast { get; }

		/// <summary>
		/// Initializes a new instance of the <see cref="IndexedItem{T}"/>.
		/// </summary>
		/// <param name="item">The value of the element.</param>
		/// <param name="index">The index of the element in a sequence.</param>
		/// <param name="isFirst">A value indicating whether this instance is first.</param>
		/// <param name="isLast">A value indicating whether this instance is last.</param>
		public IndexedItem(T item, int index, bool isFirst, bool isLast) : this()
		{
			Index = index;
			Item = item;
			IsFirst = isFirst;
			IsLast = isLast;
		}

		#region Equality members
		/// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
		/// <returns>
		/// true if the current object is equal to the <paramref name="other"/> parameter; otherwise, false.
		/// </returns>
		/// <param name="other">An object to compare with this object.</param>
		public bool Equals(IndexedItem<T> other) => EqualityComparer<T>.Default.Equals(Item, other.Item);

		/// <summary>Indicates whether this instance and a specified object are equal.</summary>
		/// <returns>
		/// true if <paramref name="obj"/> and this instance are the same type and represent the same value; otherwise, false.
		/// </returns>
		/// <param name="obj">The object to compare with the current instance. </param>
		public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			return obj is IndexedItem<T> && Equals((IndexedItem<T>)obj);
		}

		/// <summary>Returns the hash code for this instance.</summary>
		/// <returns>A 32-bit signed integer that is the hash code for this instance.</returns>
		public override int GetHashCode() => EqualityComparer<T>.Default.GetHashCode(Item);

		/// <summary>
		/// Operator ==
		/// </summary>
		/// <param name="left">Left operand</param>
		/// <param name="right">Right operand</param>
		/// <returns>True? if operands equals</returns>
		public static bool operator ==(IndexedItem<T> left, IndexedItem<T> right) => left.Equals(right);

		/// <summary>
		/// Operator !=
		/// </summary>
		/// <param name="left">Left operand</param>
		/// <param name="right">Right operand</param>
		/// <returns>True? if operands equals</returns>
		public static bool operator !=(IndexedItem<T> left, IndexedItem<T> right) => !left.Equals(right);
		#endregion
	}
}