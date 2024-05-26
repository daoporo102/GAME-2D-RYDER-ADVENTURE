using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMoveming : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWaypointIndex = 0;

    [SerializeField] private float speed = 3f;


    private void Update()
    {
        //Kiểm tra nếu đối tượng đã đến gần đến điểm đánh dấu hiện tại (khoảng cách giữa vị trí hiện tại và điểm đánh dấu là nhỏ hơn 0.1).
        if (Vector2.Distance(waypoints[currentWaypointIndex].transform.position, transform.position) < .1f)
        {
            //Nếu điều kiện kiểm tra là đúng, chỉ số của điểm đánh dấu tăng lên
            currentWaypointIndex++;
            //nếu đối tượng đã đi qua tất cả các điểm đánh dấu
            if (currentWaypointIndex >= waypoints.Length)
            {
                //nó sẽ quay lại điểm đầu tiên.
                currentWaypointIndex = 0;
            }
        }
        //di chuyển đối tượng tới vị trí của điểm đánh dấu tiếp theo bằng cách sử dụng Vector2.MoveTowards() để di chuyển dần về phía đó với tốc độ được xác định bởi biến speed.
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, Time.deltaTime * speed);

    }
}
