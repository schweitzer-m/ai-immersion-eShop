# Order validation

Orders are validated by `OrderValidator.ValidateAsync` in `src/Ordering.API/Application/Validation/OrderValidator.cs`
and every change is recorded through `IOrderAuditService` (see `docs/rfcs/order-audit.md`).
