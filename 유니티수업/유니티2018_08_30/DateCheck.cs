using UnityEngine;
using System.Collections;

public class DateCheck : MonoBehaviour {
	
	System.DateTime now;
	
	int nowMonth;
	int nowDay;
	
	// 이전에 프로그램을 실행한 날짜를 담는 변수
	int oldMonth	= 0;
	int oldDay		= 0;
	
	public AudioClip voice_date0101;
	public AudioClip voice_date0115;
	public AudioClip voice_date0203;
	public AudioClip voice_date0211;
	public AudioClip voice_date0214;
	public AudioClip voice_date0303;
	public AudioClip voice_date0314;
	public AudioClip voice_date0319;
	public AudioClip voice_date0401;
	public AudioClip voice_date0421;
	public AudioClip voice_date0422;
	public AudioClip voice_date0503;
	public AudioClip voice_date0504;
	public AudioClip voice_date0505;
	public AudioClip voice_date0602;
	public AudioClip voice_date0707;
	public AudioClip voice_date0720;
	public AudioClip voice_date0813;
	public AudioClip voice_date0915;
	public AudioClip voice_date0922;
	public AudioClip voice_date1008;
	public AudioClip voice_date1010;
	public AudioClip voice_date1103;
	public AudioClip voice_date1123;
	public AudioClip voice_date1224;
	public AudioClip voice_date1225;
	public AudioClip voice_date1231;
	
	public AudioClip[,] voice_date;
	
	private AudioSource univoice;
	
	// Use this for initialization
	void Start () {
		
		univoice	= GetComponent<AudioSource> ();

        // 이전에 프로그램을 실행한 날짜를 담는 변수
		oldMonth	= PlayerPrefs.GetInt("Month");
		oldDay		= PlayerPrefs.GetInt("Day");
		
		//Debug.Log("이전 실행일：" + oldMonth + "월" + oldDay + "일");

        // 현재 시간을 얻는다
		now = System.DateTime.Now;
		
		nowMonth	= now.Month;
		nowDay		= now.Day;
		
		// 오늘의 날짜를 저장
		PlayerPrefs.SetInt("Month", now.Month);
		PlayerPrefs.SetInt("Day", now.Day);
		
		// 음성 데이터를 배열에 넣는다
		voice_date = new AudioClip[12+1,31+1];
		voice_date0101 = Resources.Load("Voice/univ1316") as AudioClip;
		voice_date0115 = Resources.Load("Voice/univ1317") as AudioClip;
		voice_date0203 = Resources.Load("Voice/univ1318") as AudioClip;
		voice_date0211 = Resources.Load("Voice/univ1319") as AudioClip;
		voice_date0214 = Resources.Load("Voice/univ1320") as AudioClip;
		voice_date0303 = Resources.Load("Voice/univ1321") as AudioClip;
		voice_date0314 = Resources.Load("Voice/univ1322") as AudioClip;
		voice_date0319 = Resources.Load("Voice/univ1323") as AudioClip;
		voice_date0401 = Resources.Load("Voice/univ1324") as AudioClip;
		voice_date0421 = Resources.Load("Voice/univ1325") as AudioClip;
		voice_date0422 = Resources.Load("Voice/univ1326") as AudioClip;
		voice_date0503 = Resources.Load("Voice/univ1327") as AudioClip;
		voice_date0504 = Resources.Load("Voice/univ1328") as AudioClip;
		voice_date0505 = Resources.Load("Voice/univ1329") as AudioClip;
		voice_date0602 = Resources.Load("Voice/univ1330") as AudioClip;
		voice_date0707 = Resources.Load("Voice/univ1331") as AudioClip;
		voice_date0720 = Resources.Load("Voice/univ1332") as AudioClip;
		voice_date0813 = Resources.Load("Voice/univ1333") as AudioClip;
		voice_date0915 = Resources.Load("Voice/univ1334") as AudioClip;
		voice_date0922 = Resources.Load("Voice/univ1335") as AudioClip;
		voice_date1008 = Resources.Load("Voice/univ1336") as AudioClip;
		voice_date1010 = Resources.Load("Voice/univ1337") as AudioClip;
		voice_date1103 = Resources.Load("Voice/univ1338") as AudioClip;
		voice_date1123 = Resources.Load("Voice/univ1339") as AudioClip;
		voice_date1224 = Resources.Load("Voice/univ1340") as AudioClip;
		voice_date1225 = Resources.Load("Voice/univ1341") as AudioClip;
		voice_date1231 = Resources.Load("Voice/univ1342") as AudioClip;

		voice_date[1,1]		= voice_date0101;
		voice_date[1,15]	= voice_date0115;
		voice_date[2,3]		= voice_date0203;
		voice_date[2,11]	= voice_date0211;
		voice_date[2,14]	= voice_date0214;
		voice_date[3,4]		= voice_date0303;
		voice_date[3,14]	= voice_date0314;
		voice_date[3,19]	= voice_date0319;
		voice_date[4,1]		= voice_date0401;
		voice_date[4,21]	= voice_date0421;
		voice_date[4,22]	= voice_date0422;
		voice_date[5,3]		= voice_date0503;
		voice_date[5,4]		= voice_date0504;
		voice_date[5,5]		= voice_date0505;
		voice_date[6,2]		= voice_date0602;
		voice_date[7,7]		= voice_date0707;
		voice_date[7,20]	= voice_date0720;
		voice_date[8,13]	= voice_date0813;
		voice_date[9,15]	= voice_date0915;
		voice_date[9,22]	= voice_date0922;
		voice_date[10,08]	= voice_date1008;
		voice_date[10,10]	= voice_date1010;
		voice_date[11,3]	= voice_date1103;
		voice_date[11,23]	= voice_date1123;
		voice_date[12,24]	= voice_date1224;
		voice_date[12,25]	= voice_date1225;
		voice_date[12,31]	= voice_date1231;
		
		if(oldMonth != nowMonth || oldDay != nowDay){
			
			//해당 음성이 있는지 검사
			if(voice_date[nowMonth,nowDay] != null){
				
				univoice.PlayOneShot(voice_date[nowMonth,nowDay]);
			}
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
