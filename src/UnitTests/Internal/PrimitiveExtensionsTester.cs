using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using NBehave.Spec.NUnit;

namespace AutoMapper.UnitTests
{
	[TestFixture]
	public class PrimitiveExtensionsTester
	{
		[Test]
		public void Should_not_flag_only_enumerable_type_as_writeable_collection()
		{
			typeof(string).IsWriteableCollectionType().ShouldBeFalse();
		}

		[Test]
		public void Should_flag_list_as_writable_collection()
		{
			typeof(ArrayList).IsWriteableCollectionType().ShouldBeTrue();
		}

		[Test]
		public void Should_flag_generic_list_as_writeable_collection()
		{
			typeof(List<int>).IsWriteableCollectionType().ShouldBeTrue();
		}

		[Test]
		public void Should_flag_dictionary_as_writeable_collection()
		{
			typeof(Dictionary<string, int>).IsWriteableCollectionType().ShouldBeTrue();
		}
	}
}