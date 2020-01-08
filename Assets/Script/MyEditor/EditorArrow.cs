using UnityEngine;
using System.Collections;
using VoxelBusters.RuntimeSerialization;
public class EditorArrow : MonoBehaviour {

    [HideInInspector]
    public GameObject objToSet;
    public GameObject serialRoot;

    private const float MOVE_STEP=3f;
    private int indexV=250;
    private int indexH=250;

//    private const int UP=100;
//    private const int DOWN=101;
//    private const int LEFT=102;
//    private const int RIGHT=103;

    public enum Direction{
         UP,
         DOWN,
         LEFT,
         RIGHT
    }


    public void ChangeObjToSet(GameObject block){
        Destroy(objToSet);

        float x=this.transform.position.x;
        float y=this.transform.position.y;
        if(block!=null)
            objToSet=(GameObject)Instantiate(block,new Vector3(x,y,0f),Quaternion.identity);
        
    }
    public void setObj(){
        
        EditorManager em=GameObject.FindObjectOfType<EditorManager>();
        if(em.blockMap[indexV,indexH]!=null){
            Destroy(em.blockMap[indexV,indexH]);
        }
        float x=this.transform.position.x;
        float y=this.transform.position.y;

        GameObject tmp=null;
        if(objToSet!=null){
            tmp=(GameObject)RSUtility.Instantiate(objToSet,new Vector3(x,y,0f),Quaternion.identity);
            tmp.transform.parent=serialRoot.transform;
            GameObject.FindObjectOfType<SoapEditorSerialize>().m_spawnedGameObjectList.Add(tmp);
        }
        em.blockMap[indexV,indexH]=tmp;
    }

	void Start () {
        indexH=250;
        indexV=250;
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if(Input.GetKeyDown(KeyCode.Space)||Input.GetKey(KeyCode.Return)){
            setObj();
        }
        getKeyInput();
	
	}


    void OnClick(){
        setObj();
    }

    private void getKeyInput(){
        if(Input.GetKeyDown(KeyCode.UpArrow)){
            moveArrow((int)Direction.UP);
        }
        if(Input.GetKeyDown(KeyCode.DownArrow)){
            moveArrow((int)Direction.DOWN);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow)){
            moveArrow((int)Direction.LEFT);
        }
        if(Input.GetKeyDown(KeyCode.RightArrow)){
            moveArrow((int)Direction.RIGHT);
        }
    }
    public void moveArrow(int direct){
        Direction direction=(Direction)direct;
        if(direction==Direction.UP){
            this.transform.Translate(new Vector3(0f,3f,0f));
            if(objToSet!=null)objToSet.transform.Translate(new Vector3(0f,3f,0f));
            indexV--;
        }
        if(direction==Direction.DOWN){
            this.transform.Translate(new Vector3(0f,-3f,0f));
            if(objToSet!=null)objToSet.transform.Translate(new Vector3(0f,-3f,0f));
            indexV++;
        }

        if(direction==Direction.LEFT){
            this.transform.Translate(new Vector3(-3f,0f,0f));
            if(objToSet!=null)objToSet.transform.Translate(new Vector3(-3f,0f,0f));
            indexH--;
        }
        if(direction==Direction.RIGHT){
            this.transform.Translate(new Vector3(3f,0f,0f));
            if(objToSet!=null)objToSet.transform.Translate(new Vector3(3f,0f,0f));
            indexH++;
        }
    }
}
