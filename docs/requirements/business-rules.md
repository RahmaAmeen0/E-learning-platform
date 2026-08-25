# Business Rules

## 1. Identity & Account Rules

### BR-01 — Unique Email

Each user account must have a unique email address.

### BR-02 — Account Status

A deactivated user must not be allowed to authenticate or perform protected operations.

### BR-03 — Password Security

Passwords must never be stored in plain text.

### BR-04 — Role Assignment

Users must only receive roles through authorized system operations.

### BR-05 — Email Verification

Operations that require a verified email must not be available until the user's email address has been verified.

---

## 2. Authorization Rules

### BR-06 — Role Authorization

Users may only perform operations permitted for their assigned roles.

### BR-07 — Course Ownership

An instructor may only modify courses they own unless an administrator has the required permissions.

### BR-08 — Administrative Access

Administrative operations must only be available to authorized administrators.

---

## 3. Course Rules

### BR-09 — Course Ownership

Every course must have an instructor owner.

### BR-10 — Course Draft State

A newly created course must initially be in a draft state.

### BR-11 — Course Publishing

A course must satisfy all required publishing conditions before it can be published.

### BR-12 — Published Course

A published course must contain the minimum required information and learning content.

### BR-13 — Course Modification

Only authorized users may modify course information.

### BR-14 — Course Deletion

A course with active enrollments must not be permanently deleted without satisfying the platform's deletion policy.

### BR-15 — Course Visibility

Only published courses are available for public enrollment.

---

## 4. Section & Lesson Rules

### BR-16 — Section Ownership

Sections belong to a specific course.

### BR-17 — Lesson Ownership

Lessons belong to a specific section and therefore to a specific course.

### BR-18 — Lesson Ordering

Lessons within a section must maintain a defined order.

### BR-19 — Section Ordering

Sections within a course must maintain a defined order.

### BR-20 — Published Content

Only authorized instructors may modify published learning content.

---

## 5. Enrollment Rules

### BR-21 — Published Course Enrollment

A student may only enroll in a published course.

### BR-22 — Duplicate Enrollment

A student may not have more than one active enrollment in the same course.

### BR-23 — Enrollment Eligibility

Only users with the Student role may create student enrollments.

### BR-24 — Free Course Enrollment

A student may enroll in an eligible free course without payment.

### BR-25 — Paid Course Enrollment

A student must have a successfully confirmed payment before being enrolled in a paid course.

### BR-26 — Enrollment Ownership

Students may only access and manage their own enrollments.

---

## 6. Learning Progress Rules

### BR-27 — Progress Ownership

A student may only modify progress associated with their own enrollment.

### BR-28 — Enrollment Required

A student must be enrolled in a course before accessing protected learning progress.

### BR-29 — Lesson Completion

A lesson may only be marked as completed by an eligible enrolled student.

### BR-30 — Progress Calculation

Course progress must be calculated according to the defined lesson completion rules.

### BR-31 — Course Completion

A course may only be considered completed when all required completion conditions are satisfied.

### BR-32 — Progress Consistency

The system must prevent inconsistent progress states caused by concurrent updates.

---

## 7. Quiz Rules

### BR-33 — Quiz Ownership

A quiz belongs to a specific course.

### BR-34 — Quiz Access

A student must satisfy the course's quiz access requirements before starting a quiz.

### BR-35 — Quiz Attempt

Each quiz attempt belongs to one student and one quiz.

### BR-36 — Attempt Limit

A quiz may define a maximum number of attempts.

### BR-37 — Submitted Attempt

A submitted quiz attempt cannot be modified unless the quiz policy explicitly allows it.

### BR-38 — Score Calculation

Quiz scores must be calculated by the server using the configured assessment rules.

### BR-39 — Answer Validation

The client must not be trusted to determine whether an answer is correct.

---

## 8. Certificate Rules

### BR-40 — Certificate Eligibility

A student may only receive a certificate after satisfying the course completion requirements.

### BR-41 — Unique Certificate

Every issued certificate must have a unique verification identifier.

### BR-42 — Certificate Immutability

An issued certificate must not be modified in a way that invalidates its verification history.

### BR-43 — Certificate Verification

A certificate must be verifiable using its unique identifier.

---

## 9. Review & Rating Rules

### BR-44 — Review Eligibility

Only eligible students may submit reviews for a course.

### BR-45 — One Review

A student may have at most one active review for a course.

### BR-46 — Review Ownership

Students may only modify or delete their own reviews unless an administrator performs moderation.

### BR-47 — Rating Range

Course ratings must be restricted to the supported rating range.

### BR-48 — Review Moderation

Administrators may moderate reviews according to platform policies.

---

## 10. Notification Rules

### BR-49 — Notification Ownership

Users may only access their own notifications.

### BR-50 — Notification Status

A notification may transition between defined states such as unread and read.

### BR-51 — Notification Preferences

Notifications must respect the user's supported notification preferences where applicable.

### BR-52 — Notification Delivery

Failure to deliver an external notification must not necessarily cause the original business operation to fail.

---

## 11. Live Session Rules

### BR-53 — Session Ownership

A live session belongs to the instructor who created it.

### BR-54 — Session Access

Only eligible users may join a live session.

### BR-55 — Session State

A live session must have a defined lifecycle such as scheduled, active, ended, or cancelled.

### BR-56 — Real-Time Presence

The system must maintain participant presence information during active sessions.

---

## 12. Payment Rules

### BR-57 — Payment Ownership

Every payment must be associated with the user and the relevant purchase context.

### BR-58 — Payment Verification

Payment status must be determined using trusted information from the payment provider.

### BR-59 — Client Trust

The system must not rely solely on payment status supplied by the client.

### BR-60 — Webhook Verification

Incoming payment webhooks must be authenticated or verified according to the payment provider's security mechanism.

### BR-61 — Payment Idempotency

Processing the same payment event multiple times must not create duplicate business effects.

### BR-62 — Enrollment Consistency

A paid enrollment must only be created after successful payment confirmation.

### BR-63 — Failed Payment

A failed or cancelled payment must not result in a successful paid enrollment.

---

## 13. File & Video Rules

### BR-64 — File Ownership

Uploaded course content must belong to an authorized course or lesson.

### BR-65 — File Validation

Uploaded files must satisfy supported file type, size, and security requirements.

### BR-66 — Protected Content

Protected course content must only be accessible to authorized users.

### BR-67 — Storage Independence

The application database must store file metadata rather than relying on database storage for large media files where external storage is used.

---

## 14. Background Processing Rules

### BR-68 — Asynchronous Operations

Operations that are long-running or not required to complete within the originating request should be processed asynchronously where appropriate.

### BR-69 — Retry Safety

Background operations must be designed to safely handle retries.

### BR-70 — Failure Handling

Repeatedly failed background operations must be captured and handled according to the configured failure policy.

---

## 15. Messaging Rules

### BR-71 — Event Consistency

Published events must represent valid business state transitions.

### BR-72 — Idempotent Consumers

Consumers must safely handle duplicate message delivery.

### BR-73 — Failed Messages

Messages that cannot be successfully processed after the configured retry policy must be moved to an appropriate failure-handling mechanism.

---

## 16. Administrative Rules

### BR-74 — Administrative Authority

Administrative operations must only be performed by authorized administrators.

### BR-75 — User Moderation

Administrators may deactivate accounts according to platform policies.

### BR-76 — Course Moderation

Administrators may moderate or restrict courses that violate platform policies.

### BR-77 — Auditability

Security-sensitive and administrative operations should be auditable.

---

## 17. Data Integrity Rules

### BR-78 — Referential Integrity

Entities must not reference resources that do not exist.

### BR-79 — Transactional Consistency

Operations that require multiple related state changes must maintain transactional consistency.

### BR-80 — Concurrent Updates

The system must handle concurrent modifications without silently overwriting valid changes.

### BR-81 — State Transitions

Entities with defined lifecycle states must only transition between valid states.

---

## 18. Security Rules

### BR-82 — Sensitive Data Protection

Sensitive information must not be exposed through API responses, logs, or client-accessible data unless explicitly required.

### BR-83 — Secret Management

Application secrets and credentials must not be stored in source control.

### BR-84 — Input Validation

All externally supplied input must be validated before being processed.

### BR-85 — Authorization Before Access

Authorization must be evaluated before exposing protected resources or performing protected operations.

### BR-86 — Rate Limiting

Sensitive or abuse-prone endpoints should be protected using appropriate rate-limiting policies.

---

## 19. Audit Rules

### BR-87 — Important Operations

Important security, administrative, payment, and business operations should generate appropriate audit information.

### BR-88 — Audit Integrity

Audit information must not be casually modified or deleted by regular users.
