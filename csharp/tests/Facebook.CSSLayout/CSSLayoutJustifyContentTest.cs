/**
 * Copyright (c) 2014-present, Facebook, Inc.
 * All rights reserved.
 *
 * This source code is licensed under the BSD-style license found in the
 * LICENSE file in the root directory of this source tree. An additional grant
 * of patent rights can be found in the PATENTS file in the same directory.
 */

/**
 * @Generated by gentest/gentest.sh with the following input
 *
<div id="justify_content_row_flex_start" style="width: 102px; height: 102px; flex-direction: row; justify-content: flex-start;">
  <div style="width: 10px;"></div>
  <div style="width: 10px;"></div>
  <div style="width: 10px;"></div>
</div>

<div id="justify_content_row_flex_end" style="width: 102px; height: 102px; flex-direction: row; justify-content: flex-end;">
  <div style="width: 10px;"></div>
  <div style="width: 10px;"></div>
  <div style="width: 10px;"></div>
</div>

<div id="justify_content_row_center" style="width: 102px; height: 102px; flex-direction: row; justify-content: center;">
  <div style="width: 10px;"></div>
  <div style="width: 10px;"></div>
  <div style="width: 10px;"></div>
</div>

<div id="justify_content_row_space_between" style="width: 102px; height: 102px; flex-direction: row; justify-content: space-between;">
  <div style="width: 10px;"></div>
  <div style="width: 10px;"></div>
  <div style="width: 10px;"></div>
</div>

<div id="justify_content_row_space_around" style="width: 102px; height: 102px; flex-direction: row; justify-content: space-around;">
  <div style="width: 10px;"></div>
  <div style="width: 10px;"></div>
  <div style="width: 10px;"></div>
</div>

<div id="justify_content_column_flex_start" style="width: 102px; height: 102px; justify-content: flex-start;">
  <div style="height: 10px;"></div>
  <div style="heigth: 10px;"></div>
  <div style="height: 10px;"></div>
</div>

<div id="justify_content_column_flex_end" style="width: 102px; height: 102px; justify-content: flex-end;">
  <div style="height: 10px;"></div>
  <div style="height: 10px;"></div>
  <div style="height: 10px;"></div>
</div>

<div id="justify_content_column_center" style="width: 102px; height: 102px; justify-content: center;">
  <div style="height: 10px;"></div>
  <div style="height: 10px;"></div>
  <div style="height: 10px;"></div>
</div>

<div id="justify_content_column_space_between" style="width: 102px; height: 102px; justify-content: space-between;">
  <div style="height: 10px;"></div>
  <div style="height: 10px;"></div>
  <div style="height: 10px;"></div>
</div>

<div id="justify_content_column_space_around" style="width: 102px; height: 102px; justify-content: space-around;">
  <div style="height: 10px;"></div>
  <div style="height: 10px;"></div>
  <div style="height: 10px;"></div>
</div>
 *
 */

using System;
using NUnit.Framework;

namespace Facebook.CSSLayout
{
    [TestFixture]
    public class CSSLayoutJustifyContentTest
    {
        [Test]
        public void Test_justify_content_row_flex_start()
        {
            CSSNode root = new CSSNode();
            root.FlexDirection = CSSFlexDirection.Row;
            root.StyleWidth = 102;
            root.StyleHeight = 102;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 10;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleWidth = 10;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleWidth = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(10, root_child0.LayoutWidth);
            Assert.AreEqual(102, root_child0.LayoutHeight);

            Assert.AreEqual(10, root_child1.LayoutX);
            Assert.AreEqual(0, root_child1.LayoutY);
            Assert.AreEqual(10, root_child1.LayoutWidth);
            Assert.AreEqual(102, root_child1.LayoutHeight);

            Assert.AreEqual(20, root_child2.LayoutX);
            Assert.AreEqual(0, root_child2.LayoutY);
            Assert.AreEqual(10, root_child2.LayoutWidth);
            Assert.AreEqual(102, root_child2.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(92, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(10, root_child0.LayoutWidth);
            Assert.AreEqual(102, root_child0.LayoutHeight);

            Assert.AreEqual(82, root_child1.LayoutX);
            Assert.AreEqual(0, root_child1.LayoutY);
            Assert.AreEqual(10, root_child1.LayoutWidth);
            Assert.AreEqual(102, root_child1.LayoutHeight);

            Assert.AreEqual(72, root_child2.LayoutX);
            Assert.AreEqual(0, root_child2.LayoutY);
            Assert.AreEqual(10, root_child2.LayoutWidth);
            Assert.AreEqual(102, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_justify_content_row_flex_end()
        {
            CSSNode root = new CSSNode();
            root.FlexDirection = CSSFlexDirection.Row;
            root.JustifyContent = CSSJustify.FlexEnd;
            root.StyleWidth = 102;
            root.StyleHeight = 102;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 10;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleWidth = 10;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleWidth = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(72, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(10, root_child0.LayoutWidth);
            Assert.AreEqual(102, root_child0.LayoutHeight);

            Assert.AreEqual(82, root_child1.LayoutX);
            Assert.AreEqual(0, root_child1.LayoutY);
            Assert.AreEqual(10, root_child1.LayoutWidth);
            Assert.AreEqual(102, root_child1.LayoutHeight);

            Assert.AreEqual(92, root_child2.LayoutX);
            Assert.AreEqual(0, root_child2.LayoutY);
            Assert.AreEqual(10, root_child2.LayoutWidth);
            Assert.AreEqual(102, root_child2.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(20, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(10, root_child0.LayoutWidth);
            Assert.AreEqual(102, root_child0.LayoutHeight);

            Assert.AreEqual(10, root_child1.LayoutX);
            Assert.AreEqual(0, root_child1.LayoutY);
            Assert.AreEqual(10, root_child1.LayoutWidth);
            Assert.AreEqual(102, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(0, root_child2.LayoutY);
            Assert.AreEqual(10, root_child2.LayoutWidth);
            Assert.AreEqual(102, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_justify_content_row_center()
        {
            CSSNode root = new CSSNode();
            root.FlexDirection = CSSFlexDirection.Row;
            root.JustifyContent = CSSJustify.Center;
            root.StyleWidth = 102;
            root.StyleHeight = 102;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 10;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleWidth = 10;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleWidth = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(36, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(10, root_child0.LayoutWidth);
            Assert.AreEqual(102, root_child0.LayoutHeight);

            Assert.AreEqual(46, root_child1.LayoutX);
            Assert.AreEqual(0, root_child1.LayoutY);
            Assert.AreEqual(10, root_child1.LayoutWidth);
            Assert.AreEqual(102, root_child1.LayoutHeight);

            Assert.AreEqual(56, root_child2.LayoutX);
            Assert.AreEqual(0, root_child2.LayoutY);
            Assert.AreEqual(10, root_child2.LayoutWidth);
            Assert.AreEqual(102, root_child2.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(56, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(10, root_child0.LayoutWidth);
            Assert.AreEqual(102, root_child0.LayoutHeight);

            Assert.AreEqual(46, root_child1.LayoutX);
            Assert.AreEqual(0, root_child1.LayoutY);
            Assert.AreEqual(10, root_child1.LayoutWidth);
            Assert.AreEqual(102, root_child1.LayoutHeight);

            Assert.AreEqual(36, root_child2.LayoutX);
            Assert.AreEqual(0, root_child2.LayoutY);
            Assert.AreEqual(10, root_child2.LayoutWidth);
            Assert.AreEqual(102, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_justify_content_row_space_between()
        {
            CSSNode root = new CSSNode();
            root.FlexDirection = CSSFlexDirection.Row;
            root.JustifyContent = CSSJustify.SpaceBetween;
            root.StyleWidth = 102;
            root.StyleHeight = 102;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 10;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleWidth = 10;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleWidth = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(10, root_child0.LayoutWidth);
            Assert.AreEqual(102, root_child0.LayoutHeight);

            Assert.AreEqual(46, root_child1.LayoutX);
            Assert.AreEqual(0, root_child1.LayoutY);
            Assert.AreEqual(10, root_child1.LayoutWidth);
            Assert.AreEqual(102, root_child1.LayoutHeight);

            Assert.AreEqual(92, root_child2.LayoutX);
            Assert.AreEqual(0, root_child2.LayoutY);
            Assert.AreEqual(10, root_child2.LayoutWidth);
            Assert.AreEqual(102, root_child2.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(92, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(10, root_child0.LayoutWidth);
            Assert.AreEqual(102, root_child0.LayoutHeight);

            Assert.AreEqual(46, root_child1.LayoutX);
            Assert.AreEqual(0, root_child1.LayoutY);
            Assert.AreEqual(10, root_child1.LayoutWidth);
            Assert.AreEqual(102, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(0, root_child2.LayoutY);
            Assert.AreEqual(10, root_child2.LayoutWidth);
            Assert.AreEqual(102, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_justify_content_row_space_around()
        {
            CSSNode root = new CSSNode();
            root.FlexDirection = CSSFlexDirection.Row;
            root.JustifyContent = CSSJustify.SpaceAround;
            root.StyleWidth = 102;
            root.StyleHeight = 102;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleWidth = 10;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleWidth = 10;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleWidth = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(12, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(10, root_child0.LayoutWidth);
            Assert.AreEqual(102, root_child0.LayoutHeight);

            Assert.AreEqual(46, root_child1.LayoutX);
            Assert.AreEqual(0, root_child1.LayoutY);
            Assert.AreEqual(10, root_child1.LayoutWidth);
            Assert.AreEqual(102, root_child1.LayoutHeight);

            Assert.AreEqual(80, root_child2.LayoutX);
            Assert.AreEqual(0, root_child2.LayoutY);
            Assert.AreEqual(10, root_child2.LayoutWidth);
            Assert.AreEqual(102, root_child2.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(80, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(10, root_child0.LayoutWidth);
            Assert.AreEqual(102, root_child0.LayoutHeight);

            Assert.AreEqual(46, root_child1.LayoutX);
            Assert.AreEqual(0, root_child1.LayoutY);
            Assert.AreEqual(10, root_child1.LayoutWidth);
            Assert.AreEqual(102, root_child1.LayoutHeight);

            Assert.AreEqual(12, root_child2.LayoutX);
            Assert.AreEqual(0, root_child2.LayoutY);
            Assert.AreEqual(10, root_child2.LayoutWidth);
            Assert.AreEqual(102, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_justify_content_column_flex_start()
        {
            CSSNode root = new CSSNode();
            root.StyleWidth = 102;
            root.StyleHeight = 102;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleHeight = 10;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleHeight = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(102, root_child0.LayoutWidth);
            Assert.AreEqual(10, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(10, root_child1.LayoutY);
            Assert.AreEqual(102, root_child1.LayoutWidth);
            Assert.AreEqual(0, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(10, root_child2.LayoutY);
            Assert.AreEqual(102, root_child2.LayoutWidth);
            Assert.AreEqual(10, root_child2.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(102, root_child0.LayoutWidth);
            Assert.AreEqual(10, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(10, root_child1.LayoutY);
            Assert.AreEqual(102, root_child1.LayoutWidth);
            Assert.AreEqual(0, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(10, root_child2.LayoutY);
            Assert.AreEqual(102, root_child2.LayoutWidth);
            Assert.AreEqual(10, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_justify_content_column_flex_end()
        {
            CSSNode root = new CSSNode();
            root.JustifyContent = CSSJustify.FlexEnd;
            root.StyleWidth = 102;
            root.StyleHeight = 102;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleHeight = 10;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleHeight = 10;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleHeight = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(72, root_child0.LayoutY);
            Assert.AreEqual(102, root_child0.LayoutWidth);
            Assert.AreEqual(10, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(82, root_child1.LayoutY);
            Assert.AreEqual(102, root_child1.LayoutWidth);
            Assert.AreEqual(10, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(92, root_child2.LayoutY);
            Assert.AreEqual(102, root_child2.LayoutWidth);
            Assert.AreEqual(10, root_child2.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(72, root_child0.LayoutY);
            Assert.AreEqual(102, root_child0.LayoutWidth);
            Assert.AreEqual(10, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(82, root_child1.LayoutY);
            Assert.AreEqual(102, root_child1.LayoutWidth);
            Assert.AreEqual(10, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(92, root_child2.LayoutY);
            Assert.AreEqual(102, root_child2.LayoutWidth);
            Assert.AreEqual(10, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_justify_content_column_center()
        {
            CSSNode root = new CSSNode();
            root.JustifyContent = CSSJustify.Center;
            root.StyleWidth = 102;
            root.StyleHeight = 102;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleHeight = 10;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleHeight = 10;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleHeight = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(36, root_child0.LayoutY);
            Assert.AreEqual(102, root_child0.LayoutWidth);
            Assert.AreEqual(10, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(46, root_child1.LayoutY);
            Assert.AreEqual(102, root_child1.LayoutWidth);
            Assert.AreEqual(10, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(56, root_child2.LayoutY);
            Assert.AreEqual(102, root_child2.LayoutWidth);
            Assert.AreEqual(10, root_child2.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(36, root_child0.LayoutY);
            Assert.AreEqual(102, root_child0.LayoutWidth);
            Assert.AreEqual(10, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(46, root_child1.LayoutY);
            Assert.AreEqual(102, root_child1.LayoutWidth);
            Assert.AreEqual(10, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(56, root_child2.LayoutY);
            Assert.AreEqual(102, root_child2.LayoutWidth);
            Assert.AreEqual(10, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_justify_content_column_space_between()
        {
            CSSNode root = new CSSNode();
            root.JustifyContent = CSSJustify.SpaceBetween;
            root.StyleWidth = 102;
            root.StyleHeight = 102;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleHeight = 10;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleHeight = 10;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleHeight = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(102, root_child0.LayoutWidth);
            Assert.AreEqual(10, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(46, root_child1.LayoutY);
            Assert.AreEqual(102, root_child1.LayoutWidth);
            Assert.AreEqual(10, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(92, root_child2.LayoutY);
            Assert.AreEqual(102, root_child2.LayoutWidth);
            Assert.AreEqual(10, root_child2.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(0, root_child0.LayoutY);
            Assert.AreEqual(102, root_child0.LayoutWidth);
            Assert.AreEqual(10, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(46, root_child1.LayoutY);
            Assert.AreEqual(102, root_child1.LayoutWidth);
            Assert.AreEqual(10, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(92, root_child2.LayoutY);
            Assert.AreEqual(102, root_child2.LayoutWidth);
            Assert.AreEqual(10, root_child2.LayoutHeight);
        }

        [Test]
        public void Test_justify_content_column_space_around()
        {
            CSSNode root = new CSSNode();
            root.JustifyContent = CSSJustify.SpaceAround;
            root.StyleWidth = 102;
            root.StyleHeight = 102;

            CSSNode root_child0 = new CSSNode();
            root_child0.StyleHeight = 10;
            root.Insert(0, root_child0);

            CSSNode root_child1 = new CSSNode();
            root_child1.StyleHeight = 10;
            root.Insert(1, root_child1);

            CSSNode root_child2 = new CSSNode();
            root_child2.StyleHeight = 10;
            root.Insert(2, root_child2);
            root.StyleDirection = CSSDirection.LeftToRight;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(12, root_child0.LayoutY);
            Assert.AreEqual(102, root_child0.LayoutWidth);
            Assert.AreEqual(10, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(46, root_child1.LayoutY);
            Assert.AreEqual(102, root_child1.LayoutWidth);
            Assert.AreEqual(10, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(80, root_child2.LayoutY);
            Assert.AreEqual(102, root_child2.LayoutWidth);
            Assert.AreEqual(10, root_child2.LayoutHeight);

            root.StyleDirection = CSSDirection.RightToLeft;
            root.CalculateLayout();

            Assert.AreEqual(0, root.LayoutX);
            Assert.AreEqual(0, root.LayoutY);
            Assert.AreEqual(102, root.LayoutWidth);
            Assert.AreEqual(102, root.LayoutHeight);

            Assert.AreEqual(0, root_child0.LayoutX);
            Assert.AreEqual(12, root_child0.LayoutY);
            Assert.AreEqual(102, root_child0.LayoutWidth);
            Assert.AreEqual(10, root_child0.LayoutHeight);

            Assert.AreEqual(0, root_child1.LayoutX);
            Assert.AreEqual(46, root_child1.LayoutY);
            Assert.AreEqual(102, root_child1.LayoutWidth);
            Assert.AreEqual(10, root_child1.LayoutHeight);

            Assert.AreEqual(0, root_child2.LayoutX);
            Assert.AreEqual(80, root_child2.LayoutY);
            Assert.AreEqual(102, root_child2.LayoutWidth);
            Assert.AreEqual(10, root_child2.LayoutHeight);
        }

    }
}
