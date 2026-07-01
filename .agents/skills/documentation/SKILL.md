---
name: documentation
description: Guidelines and instructions for generating C# extension methods usage documentation for the Maestria.Extensions.Reflection.
---

# Maestria.Extensions.Reflection Documentation Skill

Use this skill when the user requests to create, update, or expand documentation for C# extension methods in this repository.

## Documentation Guidelines

- **Directory Location**: Generate extension method documentation in `README.md` file on root directory.
- **Language**: All documentation, code comments, and explanations must be written in **English**.
- **Scope & Exclusivity**: Document every extension method from the source folder matching the documentation file name. Never group unrelated namespaces.
- **Example Coverage Requirement**: Every single method cited or listed in the documentation file **MUST** have a corresponding, functional, and clear code example showing it in action (both synchronous/asynchronous if applicable, and showing null-safe properties where relevant).
- **Null Safety Notice**: Always call out that extensions are null-safe and present examples showing input as `null` returning `null` safely without exception.
