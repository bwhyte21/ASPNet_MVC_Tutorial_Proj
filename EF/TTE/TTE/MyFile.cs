﻿public class MyClass
{
	public int P1 {get; set;}
	public int P2 {get; set;}
	public int P3 {get; set;}
	public int P4 {get; set;}
	public int P5 {get; set;}
	public int P6 {get; set;}
	public int P7 {get; set;}
	public int P8 {get; set;}
	public int P9 {get; set;}
	public int P10 {get; set;}
}
//String Array
class Student
{
	public string Sid {get; set;}
	public string SName {get; set;}
	public string Age {get; set;}
}

//Reading from an external file
 
class NewStudent
{
	public string Sid {get; set;}
	public string SName {get; set;}
	public string Email {get; set;}
	public string Avg {get; set;}
	public string Contact {get; set;}
	public string Address {get; set;}
}
//To automatically generate model classes
// input(.txt) => .tt => .cs
//Entity Framework (how EF code is generated with .tt files)
// input(.edmx) => .tt*2 => .cs*2