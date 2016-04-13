var moveSpeed : float;
var turnSpeed : float;


function Update () {

if(Input.GetButton("Forward")){ 
transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
}

if(Input.GetButton("Backward")){ 
transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
}

if(Input.GetButton("Right")){ 
transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
}

if(Input.GetButton("Left")){ 
transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime);
}



}

