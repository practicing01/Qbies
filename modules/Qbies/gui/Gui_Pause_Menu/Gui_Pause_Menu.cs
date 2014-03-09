/*Pause menu needs to be remade into its own module.*/

if (!isObject(Gui_Pause_Menu))
{

Qbies.add(TamlRead("./Gui_Pause_Menu.gui.taml"));

}

exec("./Buttons/Go_Main_Menu.cs");

function Qbies::Toggle_Pause_Menu(%this)
{

if (%this.Bool_Is_Playing)
{

if (!Gui_Pause_Menu.isAwake())
{

Canvas.pushDialog(Gui_Pause_Menu);

}
else
{

Canvas.popDialog(Gui_Pause_Menu);

}

}

}

//GlobalActionMap.bindCmd(keyboard,"escape","Qbies.Toggle_Pause_Menu();","");
