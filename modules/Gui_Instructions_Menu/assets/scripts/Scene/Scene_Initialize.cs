function Module_Gui_Instructions_Menu::Scene_Initialize(%this)
{

%Text="Instructions";
%Text=%Text NL "Touch-drag the main Qbie to get moving.";
%Text=%Text NL "Find all of the Qbies and take them to the Circbie.";
%Text=%Text NL "Collide with Tribies and the Qbies will lose their grip!";
%Text=%Text NL "";
%Text=%Text NL "Credits for code and graphics to their respective authors.";
%Text=%Text NL "";
%Text=%Text NL "Thank you for playing. ~ practicing01";

%this.Gui_Text_ML=new GuiMLTextCtrl()
{
Position="0 0";
HorizSizing="relative";
VertSizing="relative";
Text=%Text; 
Extent=Qbies.Resolution;
isContainer="1";
Profile="Gui_Profile_Modalless_Text";
hovertime="1000";
MaxLength="512";
};

Gui_Instructions_Menu.addGuiControl(%this.Gui_Text_ML);

}
