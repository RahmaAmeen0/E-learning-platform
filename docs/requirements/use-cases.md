````markdown
# System Use Cases

## 1. Authentication & Identity

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-01 | Register Account | Student / Instructor |
| UC-02 | Login | Student / Instructor / Administrator |
| UC-03 | Refresh Access Token | Authenticated User |
| UC-04 | Logout | Authenticated User |
| UC-05 | Verify Email | User |
| UC-06 | Reset Password | User |
| UC-07 | Update Profile | Authenticated User |

---

## 2. Course Discovery

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-08 | Browse Courses | Visitor / Student |
| UC-09 | Search Courses | Visitor / Student |
| UC-10 | Filter Courses | Visitor / Student |
| UC-11 | Sort Courses | Visitor / Student |
| UC-12 | View Course Details | Visitor / Student |

---

## 3. Course Management

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-13 | Create Course | Instructor |
| UC-14 | Update Course | Instructor |
| UC-15 | Delete Course | Instructor |
| UC-16 | Create Section | Instructor |
| UC-17 | Update Section | Instructor |
| UC-18 | Delete Section | Instructor |
| UC-19 | Create Lesson | Instructor |
| UC-20 | Update Lesson | Instructor |
| UC-21 | Delete Lesson | Instructor |
| UC-22 | Reorder Course Content | Instructor |
| UC-23 | Publish Course | Instructor |

---

## 4. Enrollment

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-24 | Enroll in Free Course | Student |
| UC-25 | Purchase Paid Course | Student |
| UC-26 | Complete Enrollment After Payment | System |
| UC-27 | View My Enrollments | Student |

---

## 5. Learning

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-28 | Access Course Lesson | Student |
| UC-29 | Mark Lesson as Completed | Student |
| UC-30 | View Course Progress | Student |
| UC-31 | Complete Course | System |

---

## 6. Assessment

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-32 | Create Quiz | Instructor |
| UC-33 | Update Quiz | Instructor |
| UC-34 | Add Quiz Question | Instructor |
| UC-35 | Update Quiz Question | Instructor |
| UC-36 | Start Quiz Attempt | Student |
| UC-37 | Submit Quiz | Student |
| UC-38 | Calculate Quiz Result | System |
| UC-39 | View Quiz Result | Student |
| UC-40 | View Quiz Attempts | Student |

---

## 7. Certificates

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-41 | Generate Certificate | System |
| UC-42 | View Certificate | Student |
| UC-43 | Verify Certificate | Visitor / Student |

---

## 8. Reviews & Ratings

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-44 | Submit Course Review | Student |
| UC-45 | Update Course Review | Student |
| UC-46 | Delete Course Review | Student |
| UC-47 | Moderate Review | Administrator |

---

## 9. Notifications

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-48 | Receive Notification | Student / Instructor |
| UC-49 | Mark Notification as Read | Student / Instructor |
| UC-50 | Manage Notification Preferences | Student / Instructor |
| UC-51 | Send Email Notification | System |

---

## 10. Live Learning

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-52 | Create Live Session | Instructor |
| UC-53 | Schedule Live Session | Instructor |
| UC-54 | Join Live Session | Student |
| UC-55 | Leave Live Session | Student |
| UC-56 | Track Participant Presence | System |
| UC-57 | Send Real-Time Message | Student / Instructor |
| UC-58 | Send Live Announcement | Instructor |

---

## 11. Payments

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-59 | Initiate Payment | Student |
| UC-60 | Process Payment | Payment Provider |
| UC-61 | Receive Payment Webhook | Payment Provider |
| UC-62 | Verify Payment | System |
| UC-63 | Complete Paid Enrollment | System |
| UC-64 | Handle Failed Payment | System |

---

## 12. File & Media Management

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-65 | Upload Course File | Instructor |
| UC-66 | Upload Course Video | Instructor |
| UC-67 | Access Protected Media | Student |
| UC-68 | Delete Course Media | Instructor |

---

## 13. Background Processing

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-69 | Process Background Job | System |
| UC-70 | Retry Failed Job | System |
| UC-71 | Process Failed Message | System |

---

## 14. Administration

| ID | Use Case | Primary Actor |
|---|---|---|
| UC-72 | Manage Users | Administrator |
| UC-73 | Manage Roles | Administrator |
| UC-74 | Deactivate User | Administrator |
| UC-75 | Manage Categories | Administrator |
| UC-76 | Moderate Course | Administrator |
| UC-77 | View Platform Statistics | Administrator |
| UC-78 | Generate Administrative Report | Administrator |

---

# Core Business Workflows

## Workflow 1 — Student Enrolls in a Free Course

```text
Student
   ↓
Browse Course
   ↓
View Course Details
   ↓
Enroll
   ↓
Validate Eligibility
   ↓
Create Enrollment
   ↓
Student Can Access Course
````

---

## Workflow 2 — Student Purchases a Paid Course

```text
Student
   ↓
View Paid Course
   ↓
Initiate Payment
   ↓
Payment Provider
   ↓
Payment Completed
   ↓
Webhook Received
   ↓
Verify Payment
   ↓
Create Enrollment
   ↓
Student Can Access Course
```

---

## Workflow 3 — Student Completes a Course

```text
Student
   ↓
Access Lesson
   ↓
Complete Lesson
   ↓
Update Progress
   ↓
Check Course Completion
   ↓
Course Completed
   ↓
Generate Certificate
   ↓
Notify Student
```

---

## Workflow 4 — Quiz Submission

```text
Student
   ↓
Start Quiz
   ↓
Create Attempt
   ↓
Answer Questions
   ↓
Submit Attempt
   ↓
Validate Attempt
   ↓
Calculate Score
   ↓
Store Result
   ↓
Update Progress
```

---

## Workflow 5 — Live Session

```text
Instructor
   ↓
Create Session
   ↓
Schedule Session
   ↓
Students Join
   ↓
Real-Time Connection
   ↓
Presence Tracking
   ↓
Real-Time Communication
   ↓
Session Ends
```

---

## Workflow 6 — Payment Webhook

```text
Payment Provider
       ↓
Webhook
       ↓
Verify Signature
       ↓
Check Event Idempotency
       ↓
Process Payment Event
       ↓
Update Payment State
       ↓
Create Enrollment
       ↓
Publish Domain Event
       ↓
Notify Student
```

---

# Use Case Classification

## Core Domain Use Cases

These represent the primary educational business capabilities:

* Course Management
* Enrollment
* Learning Progress
* Quiz & Assessment
* Certificates
* Live Learning

## Supporting Use Cases

* Authentication
* Notifications
* Reviews & Ratings
* File & Media Management

## Infrastructure / Integration Use Cases

* Payments
* Email Delivery
* Background Processing
* Messaging
* Monitoring

```
```
