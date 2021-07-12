// This file was auto-generated based on version 1.2.0 of the canonical data.

using Xunit;

namespace TwoFer
{
    public class TwoFerTests
    {
        [Fact]
        public void No_name_given()
        {
            Assert.Equal("One for you, one for me.", global::TwoFer.TwoFer.Speak());
        }

        [Fact]
        public void A_name_given()
        {
            Assert.Equal("One for Alice, one for me.", global::TwoFer.TwoFer.Speak("Alice"));
        }

        [Fact]
        public void Another_name_given()
        {
            Assert.Equal("One for Bob, one for me.", global::TwoFer.TwoFer.Speak("Bob"));
        }
    }
}