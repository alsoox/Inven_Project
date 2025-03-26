# Sparta's Inventory

캐릭터의 상태창 및 인벤토리 UI 구현  

![image](https://github.com/user-attachments/assets/c3f2deb4-f920-4c32-8454-4dbef8b0393d)

## 캐릭터 정보  
- 칭호 / 이름 / 레벨(경험치) / 설명
- 구현
  - 게임매니저 -> 플레이어 생성
  - 캐릭터 정보 UI 게임매니저 플레이어 정보 확인 후 셋팅

![image](https://github.com/user-attachments/assets/7a6790ca-37d0-4b55-b6b3-7a72de0b0f63)  

## 보유골드  
- 구현
  - {0:N0} / N0 서식 문자열 사용으로 천 단위 구분 표현
    
![image](https://github.com/user-attachments/assets/c542ad45-017e-42aa-9bca-40185d62ac2f)  

## 선택 메뉴  
- 구현
  - AddLister -> 버튼 클릭 시 해당 UI 셋팅
    
![image](https://github.com/user-attachments/assets/8d839258-7e2f-4e83-9dae-65e63530e96a)  

## 캐릭터 정보
- 구현
  - 게임매니저 -> 플레이어 정보 확인
  - 인벤토리(장비장착) Action 추가로 플레이어 상태값 변경  
    
![image](https://github.com/user-attachments/assets/ff4b96e8-e6c7-4027-9c97-6cb42eae2895)  

## 인벤토리  
- 구현
  - 별도 인벤토리 클래스 관리 : 보유 아이템 정보 Dictionary(아이템, 수량) 으로 관리
  - 인벤토리 UI : 게임매니저에서 관리하고 있는 인벤토리에 접근 후 슬롯 설정
  - 착용 / 해제 / 버리기 : 플레이어 상태 및 인벤토리 값 변경
  - 착용 아이템 체크표시  
    
![image](https://github.com/user-attachments/assets/85878422-bdb6-4ef6-9771-1aefad7de38d)


## ScriptableObject
아이템에 따른 정보값 ScriptableObject 로 관리  

![image](https://github.com/user-attachments/assets/ae7a798a-6b8e-4c5e-b1e7-d6c6d4038e09)
