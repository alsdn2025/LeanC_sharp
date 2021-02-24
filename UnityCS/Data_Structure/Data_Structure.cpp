// Data_Structure.cpp : 이 파일에는 'main' 함수가 포함됩니다. 거기서 프로그램 실행이 시작되고 종료됩니다.
//

#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <string>

typedef struct listNode {
	int Data;
	struct listNode* Next;
	struct listNode* Prev;

}Node;

Node* createNode(int data) {

	Node* newNode = (Node*)malloc(sizeof(Node));
	newNode->Data = data;
	newNode->Next = NULL;
	newNode->Prev = NULL;

	return newNode;
}

void deleteNode(Node* Node)
{
	// 노드 데이터 날리기~
	free(Node);
}

// index에 해당하는 Node를 return. 
// index에 해당하는 Node가 없다면 NULL을 return.
Node* getNodeAt(Node* head, int index)
{
	Node* horse = head;    //  달리는 말. 말이 head를 받는다. 
	// 말이 index가 null이 나올때까지 linked list를 달린다. 
	// null이면 그 때의 index를 return한다. 
	int count = 0;
	while (horse != NULL){
		if (count++ == index)
		{
			return horse; // horse가 지정한 index에 도달하면 그 때의 Node를 return
		}
		horse = horse->Next;
	}
	return NULL; // horse가 null에 도달하면 NULL을 return.
}


// Node의 끝 index가 아니라
// 총 Node의 수를 return 한다. 
int countNode(Node* Head)
{
	int count = 0;
	Node* horse = Head;
	while (horse != NULL)  // horse가 NULL에 도달할때까지 달린다. 
	{
		horse = horse->Next;
		count++;
	}
	return count; // NULL에 도달한 순간 count를 return한다. 
	// horse가 해당 LinkedList를 벗어나고 다음 NULL에 도달한 뒤, COUNT도 ++되기 때문에
	// LinkedList의 끝 Node의 index보다 +1 된다. 이는 총 Node의 개수이다. 
}

void addNode(Node** Head, Node* newNode)
{
	// 1. no list exists
	if ((*Head) == NULL) {
		*Head = newNode;  // 그냥 헤드에 newNode를 붙임
	}

	// 2. List exists
	else {
		Node* horse = (*Head);
		// horse의 Nest가 NULL일 때까지 달린다.
		// 즉, horse는 마지막 Node에서 멈춘다. 
		while (horse->Next != NULL) {
			horse = horse->Next;
		}
		horse->Next = newNode;
		newNode->Prev = horse;
	}
}

// CurrentNode의 Next에 newNode를 넣는다. 
void insertAfter(Node* CurrentNode, Node* newNode)
{
	////// Currnet가 달랑 혼자있다면
	if (CurrentNode->Next == NULL && CurrentNode->Prev == NULL){
		CurrentNode->Next = newNode;
		newNode->Prev = CurrentNode;
	}

	///// list에 Node가 2개이상 있을 때 

	// Current가 List의 tail이라면 == newNode를 list의 tail에 넣는다면
	if (CurrentNode->Next == NULL) {
		CurrentNode->Next = newNode;
		newNode->Prev = CurrentNode;
	}
	// Current가 List의 첫번째 / 혹은 중간이라면 == newNode를 list의 중간에 넣는다면
	else{
		newNode->Next = CurrentNode->Next;
		newNode->Prev = CurrentNode;
		CurrentNode->Next->Prev = newNode;
		CurrentNode->Next = newNode;
	}
}

void RemoveNode(Node**Head, Node* remove)
{
	/*
	// 먼저, List에 remove 혼자 덩그러니 남아있을때 처리.
	if (remove == *Head && remove->Next == NULL)
	{
		deleteNode(remove);
		*Head = NULL;    //   Head : 객체를 가르키는 포인터의 주소. 
						 //   *Head : 객체를 가르키는 포인터의 값.
						 //				= 객체의 주소. 
						 //   객체를 가르키는 포인터의 값에 NULL을 넣어줌 -> 
						 //   포인터는 더 이상 아무것도 가르키지 않음.
		remove = NULL;
	}
	else {*/
		//remove가 Head일때
		if (remove == *Head && remove->Next != NULL)
		{
			*Head = remove->Next;
			remove->Next->Prev = NULL;
		}
		// remove가 tail이 아닐때 
		if (remove->Next != NULL) {
			remove->Next->Prev = remove->Prev;
		}
		// remove가 Head가 아닐때
		if (remove->Prev != NULL)
		{
			remove->Prev->Next = (*remove).Next; // == remove->Next
		}

		deleteNode(remove);
	//}
}

int main()
{
	Node* List = NULL;
	Node* newNode = NULL;
	Node* Current = NULL; // 현재 정보를 보려는, 현재 내가focus하는 노드

	for (int i = 0; i < 5; i++)
	{
		newNode = createNode(i);
		addNode(&List, newNode);
	}
	int count = countNode(List);
	for (int i = 0; i < count; i++)
	{
		Current = getNodeAt(List, i);
		std::cout << "List["<< i << "] = "<< Current->Data << std::endl;
	}
	for (int i = 4; i >= 0; i--)
	{
		Current = getNodeAt(List, i);
		RemoveNode(&List, Current);
	}  // List안의 Node 인스턴스를 모두 제거했다. 

	count = countNode(List);

	if (List == NULL)
	{
		std::cout << "DD" << std::endl;
	}
	std::cout << "DsssD" << std::endl;
	
	return 0;

}

// 프로그램 실행: <Ctrl+F5> 또는 [디버그] > [디버깅하지 않고 시작] 메뉴
// 프로그램 디버그: <F5> 키 또는 [디버그] > [디버깅 시작] 메뉴

// 시작을 위한 팁: 
//   1. [솔루션 탐색기] 창을 사용하여 파일을 추가/관리합니다.
//   2. [팀 탐색기] 창을 사용하여 소스 제어에 연결합니다.
//   3. [출력] 창을 사용하여 빌드 출력 및 기타 메시지를 확인합니다.
//   4. [오류 목록] 창을 사용하여 오류를 봅니다.
//   5. [프로젝트] > [새 항목 추가]로 이동하여 새 코드 파일을 만들거나, [프로젝트] > [기존 항목 추가]로 이동하여 기존 코드 파일을 프로젝트에 추가합니다.
//   6. 나중에 이 프로젝트를 다시 열려면 [파일] > [열기] > [프로젝트]로 이동하고 .sln 파일을 선택합니다.
