﻿using csharp_fundamentals_loops.Main;
using NUnit.Framework;

namespace csharp_fundamentals_loops.Test
{
    public class ExerciseTest
    {
        Exercise _exercise;

        public ExerciseTest()
        {
            this._exercise = new Exercise();
        }

        [Test]
        public void numsZeroToThreeShouldContainNumsZeroToThree()
        {
            //int[] shouldBe = { 0, 1, 2, 3 };
            //this.exercise.stepOne();
            //Assertions.assertArrayEquals(shouldBe, this.exercise.numsZeroToThree);
        }

        [Test]
        public void numsFiveToTenShouldContainNumsFiveToTen()
        {
            //int[] shouldBe = { 5, 6, 7, 8, 9, 10 };
            //this.exercise.stepTwo();
            //Assertions.assertArrayEquals(shouldBe, this.exercise.numsFiveToTen);
        }

        [Test]
        public void countdownShouldBeThreeToZero()
        {
            //int[] shouldBe = { 3, 2, 1, 0 };
            //this.exercise.stepThree();
            //Assertions.assertArrayEquals(shouldBe, this.exercise.countdown);
        }

        [Test]
        public void isMyNumberAFavourite()
        {
            Assert.AreEqual(true, this._exercise.stepFour(1));
            Assert.AreEqual(true, this._exercise.stepFour(2));
            Assert.AreEqual(true, this._exercise.stepFour(4));
            Assert.AreEqual(true, this._exercise.stepFour(5));
            Assert.AreEqual(true, this._exercise.stepFour(7));
            Assert.AreEqual(true, this._exercise.stepFour(8));
            Assert.AreEqual(true, this._exercise.stepFour(10));

            Assert.AreEqual(false, this._exercise.stepFour(6));
            Assert.AreEqual(false, this._exercise.stepFour(3));
            Assert.AreEqual(false, this._exercise.stepFour(11));
        }

        [Test]
        public void isAHobby()
        {
            Assert.AreEqual(true, this._exercise.stepFive("Fishing"));
            Assert.AreEqual(true, this._exercise.stepFive("Language learning"));
            Assert.AreEqual(true, this._exercise.stepFive("Skydiving"));
            Assert.AreEqual(true, this._exercise.stepFive("Procrastinating"));

            Assert.AreEqual(false, this._exercise.stepFive("Singing"));
            Assert.AreEqual(false, this._exercise.stepFive("Dancing"));
            Assert.AreEqual(false, this._exercise.stepFive("Horse riding"));
        }
    }
}