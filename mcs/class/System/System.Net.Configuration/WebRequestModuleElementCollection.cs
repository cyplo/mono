//
// System.Net.Configuration.WebRequestModuleElementCollection.cs
//
// Authors:
//	Tim Coleman (tim@timcoleman.com)
//	Chris Toshok (toshok@ximian.com)
//
// Copyright (C) Tim Coleman, 2004
// (C) 2004,2005 Novell, Inc. (http://www.novell.com)
//

//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

#if NET_2_0 && CONFIGURATION_DEP

using System.Configuration;

namespace System.Net.Configuration 
{
	[ConfigurationCollection (typeof (WebRequestModuleElement), CollectionType = ConfigurationElementCollectionType.AddRemoveClearMap)]
	public sealed class WebRequestModuleElementCollection : ConfigurationElementCollection
	{
		#region Constructors

		public WebRequestModuleElementCollection ()
		{
		}

		#endregion // Constructors

		#region Properties

		[MonoTODO]
		public WebRequestModuleElement this [int index] {
			get { throw new NotImplementedException (); }
			set { throw new NotImplementedException (); }
		}

		[MonoTODO]
		public new WebRequestModuleElement this [string name] {
			get { return (WebRequestModuleElement) base [name]; }
			set { base [name] = value; }
		}

		#endregion // Properties

		#region Methods

		public void Add (WebRequestModuleElement element)
		{
			BaseAdd (element);
		}

		public void Clear ()
		{
			BaseClear ();
		}

		protected override ConfigurationElement CreateNewElement ()
		{
			return new WebRequestModuleElement ();
		}

		protected override object GetElementKey (ConfigurationElement element)
		{
			if (!(element is WebRequestModuleElement))
				throw new ArgumentException ("element");
			return ((WebRequestModuleElement)element).Prefix;
		}

		public int IndexOf (WebRequestModuleElement element)
		{
			return BaseIndexOf (element);
		}

		public void Remove (WebRequestModuleElement element)
		{
			BaseRemove (element.Prefix);
		}

		public void Remove (string name)
		{
			BaseRemove (name);
		}

		public void RemoveAt (int index)
		{
			BaseRemoveAt (index);
		}

		#endregion // Methods
	}
}

#endif
