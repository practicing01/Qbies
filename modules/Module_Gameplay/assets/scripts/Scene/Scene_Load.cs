exec("./Ass_Load.cs");
exec("./Ass_Unload.cs");
exec("./Variables_Initialize.cs");
exec("./Scene_Initialize.cs");
exec("./../Buttons/Buttons.cs");
exec("./../Classes/Classes.cs");
exec("./../Functions/Functions.cs");

function Module_Gameplay::Scene_Load(%this)
{

Qbies.Module_Gameplay=%this;

%this.Ass_Load();

Scene_Qbies.clear();

%this.Scene_Current=TamlRead("./../../scenes/Module_Gameplay.scene.taml");

if (!isObject(%this.Scene_Current))
{

echo("Couldn't read scene taml.");

}

%this.Scene_Current.setName("");
Scene_Set_Custom(%this.Scene_Current);

if (!isObject(Gui_Gameplay_Menu))
{

Qbies.add(TamlRead("./../../gui/Gui_Gameplay_Menu.gui.taml"));

}

Canvas.pushDialog(Gui_Gameplay_Menu);

%this.Variables_Initialize();

%this.Scene_Initialize();

}
