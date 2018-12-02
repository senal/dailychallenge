using DailyChallenge.bitwise;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DailyChallenge.Test
{
    public class PermissionHandlerTest
    {

        [Fact]
        public void VerifyHasExecute() {
            var permission = 7;

            var p = new PermissionHandler();

            var result = p.CanExecute(permission);

            result.ShouldBe(true);
        }


        [Theory]
        [InlineData(0, false)]
        [InlineData(1, true)]
        [InlineData(2, false)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(7, true)]
        public void VerifyHasRead(int permission, bool expect)
        {
            var p = new PermissionHandler();

            var result = p.CanRead(permission);

            result.ShouldBe(expect);
        }
    }
}
