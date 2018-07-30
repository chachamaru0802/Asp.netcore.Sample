using Asp.netcore.Configs;
using Asp.netcore.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Asp.netcoreTest.Configs
{
    public class AutoMapperTest
    {
        public AutoMapperTest()
        {
            AutoMapperConfig.init();
           
        }

        [Fact]
        public void InitTest()
        {
            

            var sample = new Sample { Id = 10, Name = "Name" };

            var test = Mapper.Map<User>(sample);


            Assert.Equal(sample.Id, test.Id);
            Assert.Equal(sample.Name, test.Name);
        }
    }
}
