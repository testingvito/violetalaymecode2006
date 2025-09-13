function dropDownSeleccion(){
  var f = document.seleccion.dropDown;
	var strMake = f.options[f.selectedIndex].value;
	top.location.href = strMake+"";
  document.seleccion.reset();
}

function dropDownLocator(){
  var f = document.locator.dropDown1;
	var strMake = f.options[f.selectedIndex].value;
	top.location.href = strMake+"";
  document.locator.reset();
}
