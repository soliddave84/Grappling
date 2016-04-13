#pragma strict
var player : Transform;
function Start () {

}

function Update () {
transform.Rotate(-Vector3(1,0,0) * 1);


}

function OnCollisionEnter (collision : Collision){

if (collision.transform == player)
{Destroy(gameObject);
}
}