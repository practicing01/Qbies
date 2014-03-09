function Class_Qbies_Input_Controller::onMouseWheelUp(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Qbies.setCameraZoom(Window_Qbies.getCameraZoom()+$pref::Qbies::cameraMouseZoomRate);

}

function Class_Qbies_Input_Controller::onMouseWheelDown(%this,%Modifier,%Vector_2D_Mouse_Position,%Mouse_Click_Count)
{

Window_Qbies.setCameraZoom(Window_Qbies.getCameraZoom()-$pref::Qbies::cameraMouseZoomRate);

}
