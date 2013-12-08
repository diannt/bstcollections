using System.Collections.Generic;

namespace BST.Collections
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ILinkedStack<T> : IEnumerable<T>
    {
        /// <summary>
        /// Gets the number of elements contained in the <see cref="LinkedStack&lt;T&gt;"/>.
        /// </summary>
        /// <value>
        /// The number of elements contained in the <see cref="LinkedStack&lt;T&gt;"/>.
        /// </value>
        /// <remarks>
        /// Retrieving the value of this property is an O(1) operation.
        /// </remarks>
        int Count { get; }

        /// <summary>
        /// Adds an object on top of the <see cref="LinkedStack&lt;T&gt;"/>. 
        /// </summary>
        /// <param name="item">
        /// The object to push onto the <see cref="LinkedStack&lt;T&gt;"/>.
        /// The <paramref name="item"/> can be <c>null</c> for reference types.
        /// </param>
        /// <remarks>
        /// This method is an O(1) operation.
        /// </remarks>
        void Push(T item);

        /// <summary>
        /// Determines whether an element is in the <see cref="LinkedStack&lt;T&gt;"/>.
        /// </summary>
        /// <param name="item">
        /// The object to locate in the <see cref="LinkedStack&lt;T&gt;"/>.
        /// The value can be <c>null</c> for reference types.
        /// </param>
        /// <returns>
        /// <c>true</c> if the <paramref name="item"/> is found in the
        /// <see cref="LinkedStack&lt;T&gt;"/>; otherwise, <c>false</c>.
        /// </returns>
        /// <remarks>
        /// <para>
        /// This method determines equality by calling <see cref="Object.Equals(object)"/>.
        /// To enhance performance, it is recommended that in addition to implementing
        /// <see cref="Object.Equals(object)"/>, any class/struct also implement
        /// <see cref="IEquatable&lt;T&gt;"/> interface for their own type.
        /// </para>
        /// <para>
        /// This method is an O(n) operation, where n is <see cref="Count"/>.
        /// </para>
        /// </remarks>
        bool Contains(T item);

        /// <summary>
        /// Returns the object at the top of the <see cref="LinkedStack&lt;T&gt;"/>
        /// without removing it.
        /// </summary>
        /// <returns>
        /// The object at the top of the <see cref="LinkedStack&lt;T&gt;"/>.
        /// </returns>
        /// <remarks>
        /// <para>
        /// This method is similar to the <see cref="Pop()"/> method, but <see cref="Peek()"/>
        /// does not modify the <see cref="LinkedStack&lt;T&gt;"/>.
        /// </para>
        /// <para>
        /// This method is an O(1) operation.
        /// </para>
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// The <see cref="LinkedStack&lt;T&gt;"/> is empty.
        /// </exception>
        T Peek();

        /// <summary>
        /// Removes and returns the object at the top of the <see cref="LinkedStack&lt;T&gt;"/>.
        /// </summary>
        /// <returns>
        /// The object removed from the top of the <see cref="LinkedStack&lt;T&gt;"/>.
        /// </returns>
        /// <remarks>
        /// <para>
        /// This method is similar to the <see cref="Peek()"/> method, but <see cref="Peek()"/>
        /// does not modify the <see cref="LinkedStack&lt;T&gt;"/>.
        /// </para>
        /// <para>
        /// This method is an O(1) operation.
        /// </para>
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// The <see cref="LinkedStack&lt;T&gt;"/> is empty.
        /// </exception>
        T Pop();

        /// <summary>
        /// Removes all objects from the <see cref="LinkedStack&lt;T&gt;"/>. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// <see cref="Count"/> is set to zero and references to other objects
        /// from elements of the collection are also released.
        /// </para>
        /// <para>
        /// This method is an O(1) operation.
        /// </para>
        /// </remarks>
        void Clear();

        /// <summary>
        /// Copies the <see cref="LinkedStack&lt;T&gt;"/> elements to an existing
        /// one-dimensional <see cref="Array"/>, starting at the specified array index.
        /// </summary>
        /// <param name="array">
        /// The one-dimensional <see cref="Array"/> that is the destination of the elements
        /// copied from this <see cref="LinkedStack&lt;T&gt;"/>. The <paramref name="array"/>
        /// must have zero-based indexing.
        /// </param>
        /// <param name="index">
        /// The zero-based index in the <paramref name="array"/> at which copying begins.
        /// </param>
        /// <remarks>
        /// <para>
        /// The elements are copied to the <paramref name="array"/> in last-in-first-out (LIFO)
        /// order, similar to the order of the elements returned by a succession of calls to
        /// the <see cref="Pop()"/> method.
        /// </para>
        /// <para>
        /// This method is an O(n) operation, where n is <see cref="Count"/>.
        /// </para>
        /// </remarks>
        /// <exception cref="ArgumentNullException">
        /// <paramref name="array"/> is a <c>null</c> reference.
        /// </exception>
        /// <exception cref="ArgumentOutOfRangeException">
        /// <paramref name="index"/> is outside of the <paramref name="array"/> bounds.
        /// </exception>
        /// <exception cref="ArgumentException">
        /// The number of elements in the source <see cref="LinkedStack&lt;T&gt;"/>
        /// is greater than the available space from the <paramref name="index"/> to the end
        /// of the destination <paramref name="array"/>.
        /// </exception>
        void CopyTo(T[] array, int index);

        /// <summary>
        /// Returns an enumerator that iterates through the <see cref="LinkedStack&lt;T&gt;"/>.
        /// </summary>
        /// <returns>
        /// An <see cref="LinkedStack{T}.Enumerator"/>
        /// for the <see cref="LinkedStack&lt;T&gt;"/>.
        /// </returns>
        /// <remarks>
        /// This method is an O(1) operation.
        /// </remarks>
        LinkedStack<T>.Enumerator GetEnumerator();
    }
}