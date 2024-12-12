 style.cs
*
{
margin:0px;
padding:0px;

}
body
{
	display:grid;
	grid-template-rows:200px 600px 200px;
	grid-gap:1%;
	background-color:grey;
}
header
{
	height:100%;
	width:100%;
	display:inline block;
	margin-top:30px 
	border-bottom:1px solid black;


}
form{
	float:right;
}
nav
{
	display:grid;
	grid-template-rows:20% 49%;
	grid-gap:2%;
}
#header
{
	text-align:center;
     color:black;
	text-shadow:2px,10px,5px white;
	text-decoration:underline;
	text-decoration-style:dotted;
	text-decoration-color:black;
	font-variant:small-caps;
	font-family:sketchflow print;
	padding:20px;
}
#n
{   
    color:white;
	display:flex;
	flex-direction:rows;
	flex-wrap:wrap;
	justify-content:space-between;
	background-color:black;
	text-transform:capitalize;
}
#n a
{
	color:white;
	text-decoration:none;
	position:relative;
	top:2px;
	padding-top:7px;
	width:20%;
}
.a[type="search"]
{
	height:30px;
	margin-top:50px;
	margin-left:50px;
	width:200px;
}
.a[type="submit"]
{
	height:30px;
	margin-top:10px;
	margin-left:opx;
	width:50px;
	background-color:orange;
}
.a
{
	border-radius:20px;
	margin-top:150px;
}
main
{
	display:grid;
	grid-template-rows:49% 49%;
	grid-gap:2%;
}
#s1
{
	display:grid;
	grid-template-columns:78% 20%;
	grid-gap:2%;
	background-color:sky blue;
}
#s1 img
{
	width:750px;
	height:250px;
	padding-bottom:100px;

}
 #s1 h3
{ 
  
	margin-left:50px;
	margin-top:40px:
	padding:20px;
	color:black;
	text-transform:capitalize;
	
}
#s2 ol
{
	display:grid;
	grid-template-columns:20% 20% 20% 20%;
	list-style-type:none;
	grid-gap:7%;
	text-align:center;
	background-color:grey;
}
#s2 ol li img
{
	width:100%;
	height:100%;
	border-radius:20px;
}
#s2 ol li img:hover
{
	box-shadow:10px 10px 5px red;
}
footer
{
	background-color:black;
	color:white;
	text-align:center;
}
#se,a
{
	font-size:20px;
	color:white;
	margin-left:10px;

}
# f
{
	font-size:50px;
	text-decoration:underline;

}
address
{
	front-size:25px;
	
}

	