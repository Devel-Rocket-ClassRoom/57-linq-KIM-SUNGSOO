# 상품 데이터 조회

온라인 쇼핑몰의 상품 데이터를 관리하는 프로그램을 작성함.

아래 주어진 `Product` 클래스와 상품 목록을 사용하여
다양한 LINQ 쿼리를 구현함.

**Product 클래스**

- `Name`: 상품명 (string)
- `Category`: 카테고리 (string)
- `Price`: 가격 (int)

**상품 목록**

| 상품명 | 카테고리 | 가격 |
|--------|----------|------|
| Laptop | Electronics | 1200 |
| Mouse | Electronics | 25 |
| Keyboard | Electronics | 75 |
| Shirt | Clothing | 50 |
| Pants | Clothing | 100 |
| Desk | Furniture | 250 |
| Chair | Furniture | 150 |
| Monitor | Electronics | 300 |

**구현할 쿼리**

1. 가격이 100 이상인 상품의 이름 출력
2. 카테고리가 "Electronics"인 상품 출력
3. 상품명을 알파벳 순으로 정렬하여 출력
4. 모든 상품의 평균 가격 계산
5. 가장 저렴한 상품 출력
6. 가장 비싼 상품 출력
7. "Electronics" 카테고리 상품의 평균 가격 출력
8. 상품명에 'o'가 포함된 상품을 대문자로 변환하여 출력
9. "Clothing" 카테고리 상품명을 역순으로 출력
10. 가격이 50~300 범위인 상품을 가격 오름차순으로 정렬 (같은 가격이면 이름순)

## 예상 실행 결과

```
=== 문제 1: 가격 100 이상 ===
Laptop
Pants
Desk
Chair
Monitor

=== 문제 2: Electronics 카테고리 ===
Laptop - Electronics - 1200원
Mouse - Electronics - 25원
Keyboard - Electronics - 75원
Monitor - Electronics - 300원

=== 문제 3: 이름순 정렬 ===
Chair
Desk
Keyboard
Laptop
Monitor
Mouse
Pants
Shirt

=== 문제 4: 평균 가격 ===
268.75원

=== 문제 5: 가장 저렴한 상품 ===
Mouse - 25원

=== 문제 6: 가장 비싼 상품 ===
Laptop - 1200원

=== 문제 7: Electronics 평균 가격 ===
400원

=== 문제 8: 'o' 포함 상품 (대문자) ===
LAPTOP
MOUSE
KEYBOARD
MONITOR

=== 문제 9: Clothing 역순 ===
Shirt
Pants

=== 문제 10: 가격 50~300, 복합 정렬 ===
Shirt - 50원
Keyboard - 75원
Pants - 100원
Chair - 150원
Desk - 250원
Monitor - 300원
```
