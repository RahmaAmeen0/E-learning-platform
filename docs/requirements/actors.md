# System Actors

## 1. Student

The Student is a registered platform user who consumes educational content.

### Responsibilities

- Browse published courses
- Search and filter courses
- View course details
- Enroll in courses
- Access learning content
- Track learning progress
- Complete lessons
- Take quizzes
- View assessment results
- Receive certificates
- Submit course reviews and ratings
- Join eligible live sessions
- Receive notifications
- Manage notification preferences
- Manage personal profile

---

## 2. Instructor

The Instructor is a platform user responsible for creating and delivering educational content.

### Responsibilities

- Create courses
- Update courses
- Organize course sections and lessons
- Upload course content
- Create quizzes
- Manage quiz questions
- Monitor student progress
- Schedule live sessions
- Manage live sessions
- Send announcements
- View course-related statistics

---

## 3. Administrator

The Administrator is responsible for managing and moderating the platform.

### Responsibilities

- Manage users
- Manage user roles
- Activate or deactivate accounts
- Manage course categories
- Moderate courses
- Moderate reviews
- Monitor platform activity
- View platform statistics
- Access administrative reports
- Perform authorized administrative operations

---

# External Actors

## 4. Payment Provider

An external payment service responsible for processing payments for paid courses.

### Responsibilities

- Process payment requests
- Return payment results
- Send payment status webhooks
- Provide trusted payment information

---

## 5. Email Provider

An external service responsible for delivering transactional emails.

### Responsibilities

- Send verification emails
- Send password reset emails
- Send notification emails
- Report delivery failures where supported

---

## 6. Object Storage Provider

An external storage service responsible for storing large files and media.

### Responsibilities

- Store course files
- Store video-related assets
- Provide controlled access to stored resources
- Return storage metadata

---

## 7. Message Broker

An infrastructure component responsible for asynchronous message delivery.

### Responsibilities

- Accept published messages
- Deliver messages to consumers
- Support retry mechanisms
- Support failure handling

---

## 8. Monitoring Platform

An external observability system responsible for collecting operational telemetry.

### Responsibilities

- Collect logs
- Collect metrics
- Collect traces
- Support production diagnostics

---

# Actor Categories

## Primary Actors

- Student
- Instructor
- Administrator

## External Actors

- Payment Provider
- Email Provider
- Object Storage Provider

## Infrastructure Actors

- Message Broker
- Monitoring Platform